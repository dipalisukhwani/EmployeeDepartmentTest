using EmployeeDepartmentTest.Data;
using EmployeeDepartmentTest.Entities;
using EmployeeDepartmentTest.Models;
using EmployeeDepartmentTest.Services;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDepartmentTest.Repository
{
    public class EmployeeRepository : IEmployeeService
    {
        private readonly AppDbContext _appDBContext;
        public EmployeeRepository(AppDbContext context)
        {
            _appDBContext = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            _appDBContext.Employees.Add(employee);
            await _appDBContext.SaveChangesAsync();
            return employee;
        }

        public bool DeleteEmployee(int ID)
        {
            bool result = false;
            var department = _appDBContext.Employees.Find(ID);
            if (department != null)
            {
                department.IsDeleted = true;
                _appDBContext.Entry(department).State = EntityState.Modified;
                _appDBContext.SaveChanges();
                result = true;
            }
           
            return result;
        }

        public async Task<List<EmployeeDetailsDTO>> GetEmployees()
        {
            var result = await _appDBContext.Employees
        .Include(e => e.Department)
            .Where(e => !e.IsDeleted)
        .Select(e => new EmployeeDetailsDTO
        {
            LastName = e.LastName,
            DepartmentName = e.Department.DepartmentName,
            FirstName = e.FirstName,
            Designation = e.Designation
        })
        .ToListAsync();
            return result;
        }
    }
}
