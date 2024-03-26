using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Contracts;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task LeaveAllocation(int leaveTypeId);
    Task<bool> AllocationExists(string employeesId, int leaveTypeId, int period);
    Task<EmployeeAllocationVm> GetEmployeeAllocations(string employeeId);
    Task<LeaveAllocationEditVm> GetEmployeeAllocations(int id);
    Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVm model);
}