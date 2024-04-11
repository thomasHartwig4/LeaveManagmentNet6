using LeaveManagment.Web.Data;

namespace LeaveManagment.Web.Models;

public class EmployeeLeaveRequestViewVm
{
    public EmployeeLeaveRequestViewVm(List<LeaveAllocationVm> leaveAllocations, List<LeaveRequestVm> leaveRequests)
    {
        LeaveAllocations = leaveAllocations;
        LeaveRequests = leaveRequests;
    }
    public List<LeaveAllocationVm> LeaveAllocations { get; set; }
    public List<LeaveRequestVm> LeaveRequests { get; set; }
}