using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDepartmentTest.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNumber { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Designation { get; set; }
        public decimal Salary { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Boolean IsDeleted { get; set; }
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}
