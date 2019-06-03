using Microsoft.EntityFrameworkCore;

namespace Practice.Models
{
    public class ASPNETContext : DbContext
    {
        public ASPNETContext(DbContextOptions<ASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}