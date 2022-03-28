using MoviesApi1.Models;
using Microsoft.EntityFrameworkCore;

namespace MoviesApi1.Data
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<MovieData> Movies { get; set; }
    }
}
