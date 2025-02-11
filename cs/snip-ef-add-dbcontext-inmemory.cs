builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("{{_input_:db_name}}"));