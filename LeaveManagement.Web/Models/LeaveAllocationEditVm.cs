namespace LeaveManagment.Web.Models;

public class LeaveAllocationEditVm : LeaveAllocationVm
{
    public string EmployeeId { get; set; }
    public int LeaveTypeId { get; set; }
    public EmployeeListVm? Employee { get; set; }
}