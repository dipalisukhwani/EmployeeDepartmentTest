
using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentTest.Models
{
    public record EmployeetDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        [Required]
        public int DepartmentId { get; set; }

    }
}
