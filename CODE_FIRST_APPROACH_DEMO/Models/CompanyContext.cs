using Microsoft.EntityFrameworkCore;

namespace CODE_FIRST_APPROACH_DEMO.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options):base(options)
        {
             
        }
        public DbSet<Companies> Companies { get; set; }
    }
}
