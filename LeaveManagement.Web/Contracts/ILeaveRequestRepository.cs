using System.Diagnostics.Eventing.Reader;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<bool> CreateLeaveRequest(LeaveRequestCreateVm model);
    Task<EmployeeLeaveRequestViewVm> GetMyLeaveDetails();
    Task<LeaveRequestVm?> GetLeaveRequestAsync(int? id);
    Task<List<LeaveRequest>> GetAllAsync(string employeeId);
    Task ChangeApprovalStatus(int leaverRequestId, bool approved);
    Task CancelLeaveRequest(int leaveRequestId);
    Task<AdminLeaveRequestViewVm> GetAdminLeaveRequestList();
}