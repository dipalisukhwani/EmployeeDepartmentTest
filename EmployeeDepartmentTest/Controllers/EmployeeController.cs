using AutoMapper;
using EmployeeDepartmentTest.Entities;
using EmployeeDepartmentTest.Models;
using EmployeeDepartmentTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDepartmentTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService ??
                throw new ArgumentNullException(nameof(employeeService));
            _mapper = mapper;
        }

        [HttpPost]
        [Route("AddEmployee")]
        public async Task<IActionResult> Post(EmployeetDTO employeetDTO)
        {
            var emp = _mapper.Map<Employee>(employeetDTO);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _employeeService.AddEmployee(emp);
            if (result.EmployeeId == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok(true);
        }

        [HttpDelete]
        [Route("DeleteEmployee")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _employeeService.DeleteEmployee(id);
            if (result)
            {
                return Ok(true);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetEmployees()
        {
            var result = await _employeeService.GetEmployees();
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok(result);
        }

    }
}
