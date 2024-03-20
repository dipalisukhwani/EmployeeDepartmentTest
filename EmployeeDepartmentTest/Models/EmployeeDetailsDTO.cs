using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentTest.Models
{
    public record EmployeeDetailsDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string DepartmentName { get; set; }

    }
}
