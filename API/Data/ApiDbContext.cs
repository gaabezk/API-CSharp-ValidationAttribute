using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) => Database.EnsureCreated();

        public DbSet<Estado> Estado { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }

}
