namespace {{_input:your_namespace}};

public interface I{{_input:your_repository_name}}Repository
{
}

public class {{_input:your_repository_name}}Repository : I{{_input:your_repository_name}}Repository
{
    private readonly AppDbContext _context;

    public {{_input:your_repository_name}}Repository(AppDbContext context)
    {
        _context = context;
    }
}
