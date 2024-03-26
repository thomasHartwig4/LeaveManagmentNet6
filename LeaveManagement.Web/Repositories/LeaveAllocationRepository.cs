using AutoMapper;
using LeaveManagment.Web.Constants;
using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagment.Web.Repositories;

public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{
    private readonly ApplicationDbContext context;
    private readonly UserManager<Employee> userManager;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper mapper;

    public LeaveAllocationRepository(ApplicationDbContext context, 
        UserManager<Employee> userManager, 
        ILeaveTypeRepository leaveTypeRepository,
        IMapper mapper) : base(context)
    {
        this.context = context;
        this.userManager = userManager;
        this._leaveTypeRepository = leaveTypeRepository;
        this.mapper = mapper;
    }

    public async Task<bool> AllocationExists(string employeesId, int leaveTypeId, int period)
    {
        return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeesId
                                                            && q.LeaveTypeId == leaveTypeId
                                                            && q.Period == period);
    }

    public async Task<EmployeeAllocationVm> GetEmployeeAllocations(string employeeId)
    {
        var allocations = await context.LeaveAllocations
            .Include(q => q.LeaveType)
            .Where(q => q.EmployeeId == employeeId)
            .ToListAsync();
        var employee = await userManager.FindByIdAsync(employeeId);

        var employeeAllocationModel = mapper.Map<EmployeeAllocationVm>(employee);
        employeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVm>>(allocations);

        return employeeAllocationModel;
    }
    
    public async Task<LeaveAllocationEditVm> GetEmployeeAllocations(int id)
    {
        var allocation = await context.LeaveAllocations
            .Include(q => q.LeaveType)
            .FirstOrDefaultAsync(q => q.Id == id);

        if (allocation == null)
        {
            return null;
        }

        var model = mapper.Map<LeaveAllocationEditVm>(allocation);
        model.Employee = mapper.Map<EmployeeListVm>(await userManager.FindByIdAsync(allocation.EmployeeId));

        return model;
    }

    public async Task LeaveAllocation(int leaveTypeId)
    {
        var empolyees = await userManager.GetUsersInRoleAsync(Roles.User);
        var period = DateTime.Now.Year;
        var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
        var allocations = new List<LeaveAllocation>();
        
        foreach (var employee in empolyees)
        {
            if (await AllocationExists(employee.Id, leaveTypeId, period))
            {
                continue;
            }
            allocations.Add(new LeaveAllocation()
            {
                EmployeeId = employee.Id,
                LeaveTypeId = leaveTypeId,
                Period = period,
                NumberOfDays = leaveType.DefaultDays
            });
        }
        
        await AddRangeAsync(allocations);
    }
    
    public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVm model)
    {
        var leaveAllocation = await GetAsync(model.Id);
        if (leaveAllocation == null)
        {
            return false;
        }
        leaveAllocation.Period = model.Period;
        leaveAllocation.NumberOfDays = model.NumberOfDays;
        await UpdateAsync(leaveAllocation);
        
        return true;
    }
}