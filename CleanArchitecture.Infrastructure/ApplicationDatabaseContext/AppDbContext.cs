using CleanArchitecture.Core.Entities.Log;
using CleanArchitecture.Core.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.ApplicationDatabaseContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<AuditLog> Logs { get; set; }
    }
}
