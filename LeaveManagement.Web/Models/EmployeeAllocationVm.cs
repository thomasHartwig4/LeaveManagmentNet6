using System.ComponentModel.DataAnnotations;
using LeaveManagment.Web.Data;

namespace LeaveManagment.Web.Models;

public class EmployeeAllocationVm : EmployeeListVm
{
    public List<LeaveAllocationVm> LeaveAllocations { get; set; }
}