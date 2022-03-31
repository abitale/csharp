using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UnitTest_Mock.Services;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int id)
        {
            var result = await _employeeService.GetEmployeeById(id);
            return result;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int id)
        {
            var result = await _employeeService.GetEmployeeDetails(id);
            return result;
        }
    }
}
