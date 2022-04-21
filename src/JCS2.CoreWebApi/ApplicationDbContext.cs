using JCS2.CoreWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace JCS2.CoreWebApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
