using WebApi1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }
        [HttpGet(Name ="Get Employee")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetAllEmployee();
        }
        [HttpGet("{id}", Name="Get Employee Where")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }
    }
}
