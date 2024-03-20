using System.ComponentModel.DataAnnotations;

namespace EmployeeDepartmentTest.Models
{
    public record DepartmentDTO
    {
        [Required(ErrorMessage = "DepartmentName is required")]
        public string? DepartmentName { get; set; }
    }
}
