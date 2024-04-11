using AutoMapper;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVm>().ReverseMap();
            CreateMap<Employee, EmployeeListVm>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVm>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVm>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVm>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestCreateVm>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestVm>().ReverseMap();
        }
    }
}
