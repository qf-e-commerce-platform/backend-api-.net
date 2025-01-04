using Microsoft.EntityFrameworkCore;

namespace MyApp.Infrastructure.DbContexts;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options: options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
    }
}