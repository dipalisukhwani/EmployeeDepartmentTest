using EmployeeDepartmentTest.Entities;

namespace EmployeeDepartmentTest.Services
{
    public interface IDepartmentService
    {
        Task<Department> AddDepartment(Department department);
    }
}
