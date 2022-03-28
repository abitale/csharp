using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace TodoApp1TestRun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [Route("TestRun")]
        [HttpGet]
        public ActionResult TestRun()
        {
            return Ok("Berhasil Test Run");
        }
    }
}