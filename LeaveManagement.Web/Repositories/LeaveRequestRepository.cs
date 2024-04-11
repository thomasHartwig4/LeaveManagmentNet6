using AutoMapper;
using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Controllers;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagment.Web.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly UserManager<Employee> _userManager;

    public LeaveRequestRepository(ApplicationDbContext context, 
        IMapper mapper, 
        IHttpContextAccessor httpContextAccessor,
        ILeaveAllocationRepository leaveAllocationRepository,
        UserManager<Employee> userManager) : base(context)
    {
        _context = context;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
        _leaveAllocationRepository = leaveAllocationRepository;
        _userManager = userManager;
    }
    
    public async Task CancelLeaveRequest(int leaveRequestId)
    {
        var leaveRequest = await GetAsync(leaveRequestId);
        leaveRequest.Cancelled = true;
        await UpdateAsync(leaveRequest);
    }
    
    public async Task ChangeApprovalStatus(int leaverRequestId, bool approved)
    {
        var leaveRequest = await GetAsync(leaverRequestId);
        leaveRequest.Approved = approved;
        
        if (approved)
        {
            var allocation =
                await _leaveAllocationRepository.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
            int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
            allocation.NumberOfDays -= daysRequested;

            await _leaveAllocationRepository.UpdateAsync(allocation);
        }

        await UpdateAsync(leaveRequest);
    }

    public async Task<bool> CreateLeaveRequest(LeaveRequestCreateVm model)
    {
        var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);

        var leaveAllocation = await _leaveAllocationRepository.GetEmployeeAllocation(user.Id, model.LeaveTypeId);
        
        if (leaveAllocation == null)
        {
            return false;
        }
        
        int daysRequested = (int)(model.EndDate.Value - model.StartDate.Value).TotalDays;

        if (daysRequested > leaveAllocation.NumberOfDays)
        {
            return false;
            
        }
        var leaveRequest = _mapper.Map<LeaveRequest>(model);
        leaveRequest.DateRequested = DateTime.Now;
        leaveRequest.RequestingEmployeeId = user.Id;

        await AddAsync(leaveRequest);

        return true;
    }
    
    public async Task<AdminLeaveRequestViewVm> GetAdminLeaveRequestList()
    {
        var leaveRequests = await _context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
        var model = new AdminLeaveRequestViewVm
        {
            TotalRequests = leaveRequests.Count,
            ApprovedRequest = leaveRequests.Count(q => q.Approved == true),
            PendingRequest = leaveRequests.Count(q => q.Approved == null),
            RejectedRequests = leaveRequests.Count(q => q.Approved == false),
            LeaveRequests = _mapper.Map<List<LeaveRequestVm>>(leaveRequests)
        };

        foreach (var leaveRequest in model.LeaveRequests)
        {
            leaveRequest.Employee = _mapper.Map<EmployeeListVm>(await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
        }
        
        return model;
    }

    public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
    {
        return await _context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();
    }

    public async Task<LeaveRequestVm?> GetLeaveRequestAsync(int? id)
    {
        var leaveRequest = await _context.LeaveRequests
            .Include(q => q.LeaveType)
            .FirstOrDefaultAsync(q => q.Id == id);
      
        if (leaveRequest == null)
        {
            return null;
        }
        
        var model = _mapper.Map<LeaveRequestVm>(leaveRequest);
        model.Employee = _mapper.Map<EmployeeListVm>(await _userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));
        return model;
    }

    public async Task<EmployeeLeaveRequestViewVm> GetMyLeaveDetails()
    {
        var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);
        var allocations = (await _leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
        var requests = _mapper.Map<List<LeaveRequestVm>>(await GetAllAsync(user.Id));

        var model = new EmployeeLeaveRequestViewVm(allocations, requests);

        return model;
    }
}
