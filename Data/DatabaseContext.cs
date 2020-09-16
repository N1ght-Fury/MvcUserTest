using Microsoft.EntityFrameworkCore;
using MVCTestFormApp.Models;

namespace MVCTestFormApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}