using Microsoft.EntityFrameworkCore;

namespace {{_input_:your_namespace}};

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
    {{_cursor_}}
}