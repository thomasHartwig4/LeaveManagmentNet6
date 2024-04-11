using System.ComponentModel.DataAnnotations;
using LeaveManagment.Web.Data;

namespace LeaveManagment.Web.Models;

public class AdminLeaveRequestViewVm
{
    [Display(Name = "Total Number Of Requests")]
    public int TotalRequests { get; set; }
    
    [Display(Name = "Approved Request")]
    public int ApprovedRequest { get; set; }
    
    [Display(Name = "Pending Request")]
    public int PendingRequest { get; set; }
    
    [Display(Name = "Rejected Requests")]
    public int RejectedRequests { get; set; }
    
    public List<LeaveRequestVm> LeaveRequests { get; set; }
}