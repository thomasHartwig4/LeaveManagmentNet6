using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models;

public class LeaveAllocationVm
{
    [Required] 
    public int Id { get; set; }
    
    [Display(Name = "Number of Days")]
    [Required]
    [Range(1,50, ErrorMessage = "Invalid Number Entered")]
    public int NumberOfDays { get; set; }
   
    [Required]
    [Display(Name = "Allocation Period")]
    public int Period { get; set; }
    public LeaveTypeVM? LeaveType { get; set; }
}