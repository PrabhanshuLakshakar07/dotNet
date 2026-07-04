using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyEcommerceWEB_MVC.Models;

namespace MyEcommerceWEB_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor: Ye settings Program.cs se lekar database tak pahunchata hai
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 👇 Yeh line sabse important hai!
        public DbSet<Product> Products { get; set; }
    }
}
