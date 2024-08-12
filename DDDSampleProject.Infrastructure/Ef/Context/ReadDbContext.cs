using Microsoft.EntityFrameworkCore;

namespace DDDSampleProject.Infrastructure.Ef.Context;

internal sealed class ReadDbContext:DbContext
{

	public ReadDbContext(DbContextOptions<ReadDbContext> options):base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
