using EmployeeDepartmentTest.Data;
using EmployeeDepartmentTest.Entities;
using EmployeeDepartmentTest.Services;

namespace EmployeeDepartmentTest.Repository
{
    public class DepartmentRepository : IDepartmentService
    {
        private readonly AppDbContext _appDBContext;
        public DepartmentRepository(AppDbContext context)
        {
            _appDBContext = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<Department> AddDepartment(Department department)
        {
            _appDBContext.Department.Add(department);
            await _appDBContext.SaveChangesAsync();
            return department;
        }
    }
}
