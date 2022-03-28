using Microsoft.EntityFrameworkCore;
using TodoApp1.Models;

namespace TodoApp1.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}