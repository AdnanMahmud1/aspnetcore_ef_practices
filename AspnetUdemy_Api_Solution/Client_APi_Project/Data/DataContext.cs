using Client_APi_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Client_APi_Project.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
