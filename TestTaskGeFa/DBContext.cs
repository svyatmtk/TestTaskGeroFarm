using Microsoft.EntityFrameworkCore;
using TestTaskGeFa.Models;

namespace TestTaskGeFa
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options) { }

        public DbSet<Post> posts { get; set; }
    }
}
