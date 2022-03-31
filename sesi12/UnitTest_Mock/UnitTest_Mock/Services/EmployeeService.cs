using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApiDbContext _apiDbContext;

        public EmployeeService(ApiDbContext context)
        {
            _apiDbContext = context;
        }
        public async Task<string> GetEmployeeById(int id)
        {
            var name = await _apiDbContext.Employees.Where(c => c.Id == id).Select(d => d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int id)
        {
            var employee = await _apiDbContext.Employees.FirstOrDefaultAsync(c => c.Id == id);
            return employee;
        }
    }
}
