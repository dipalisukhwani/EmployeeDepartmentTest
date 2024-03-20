using EmployeeDepartmentTest.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeDepartmentTest.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
        public DbSet<Department> Department
        {
            get;
            set;
        }
    }
}
