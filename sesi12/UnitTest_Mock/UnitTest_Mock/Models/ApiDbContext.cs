using Microsoft.EntityFrameworkCore;

namespace UnitTest_Mock.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options): base(options) { }
        public DbSet<Employee> Employees {get;set;}
    }
}
