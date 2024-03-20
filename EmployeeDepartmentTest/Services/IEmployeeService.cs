using EmployeeDepartmentTest.Entities;
using EmployeeDepartmentTest.Models;

namespace EmployeeDepartmentTest.Services
{
    public interface IEmployeeService
    {
        Task<Employee> AddEmployee(Employee employee);
        bool DeleteEmployee(int ID);
        Task<List<EmployeeDetailsDTO>> GetEmployees();
    }
}
