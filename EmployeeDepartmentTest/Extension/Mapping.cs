using AutoMapper;
using EmployeeDepartmentTest.Entities;
using EmployeeDepartmentTest.Models;

namespace EmployeeDepartmentTest.Extension
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<EmployeetDTO, Employee>();
            CreateMap<DepartmentDTO, Department>();
        }
    }
}
