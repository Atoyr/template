using Microsoft.EntityFrameworkCore;

namespace {{your_namespace}};

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}