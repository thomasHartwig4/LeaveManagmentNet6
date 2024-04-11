using System.ComponentModel.DataAnnotations;
using LeaveManagment.Web.Data;

namespace LeaveManagment.Web.Models;

public class LeaveRequestVm : LeaveRequestCreateVm
{
    public int Id { get; set; }
    
    [Display(Name = "Date Requested")]
    public DateTime DateRequested { get; set; }
    
    [Display(Name = "Leave Type")]
    public LeaveTypeVm LeaveType { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
    
    public string? RequestingEmployeeId { get; set; }
    public EmployeeListVm Employee { get; set; }
}