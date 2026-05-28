using Microsoft.EntityFrameworkCore;

namespace WEBAPI.Models
{
    public class EmpDbContext : DbContext
    {
        public DbSet<Emp> Emps { get; set; }

        public EmpDbContext(DbContextOptions options):base(options)
        {

        }


    }
}
