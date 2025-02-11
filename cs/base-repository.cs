using Microsoft.EntityFrameworkCore;

namespace {{_input_:your_namespace}};

public interface I{{_input_:your_repository_name}}Repository
{
}

public class {{_input_:your_repository_name}}Repository : I{{_input_:your_repository_name}}Repository
{
    private readonly AppDbContext _context;

    public {{_input_:your_repository_name}}Repository(AppDbContext context)
    {
        _context = context;
    }
}