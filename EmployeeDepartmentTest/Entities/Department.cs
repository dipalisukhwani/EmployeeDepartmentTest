using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentTest.Entities
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Employee>? Employees { get; set; }

    }
}
