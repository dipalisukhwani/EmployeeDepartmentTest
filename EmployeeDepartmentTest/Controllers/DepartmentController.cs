using AutoMapper;
using EmployeeDepartmentTest.Entities;
using EmployeeDepartmentTest.Models;
using EmployeeDepartmentTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDepartmentTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;
        public DepartmentController(IDepartmentService departmentService,IMapper mapper)
        {
            _departmentService = departmentService ??
                throw new ArgumentNullException(nameof(departmentService));
            _mapper = mapper;
        }

        [HttpPost]
        [Route("AddDepartment")]
        public async Task<IActionResult> Post(DepartmentDTO departmentDto)
        {
            var department = _mapper.Map<Department>(departmentDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _departmentService.AddDepartment(department);
            if (result.DepartmentId == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok(true);
        }
    }
}
