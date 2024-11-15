using Microsoft.EntityFrameworkCore;

namespace Backend.Database;

public class ApplicationDbContext: DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
	{
	}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=jobapp_db;User=root;Password=AmehisIkem;", new MySqlServerVersion(new Version(8, 4, 3)));
        }
    }
}