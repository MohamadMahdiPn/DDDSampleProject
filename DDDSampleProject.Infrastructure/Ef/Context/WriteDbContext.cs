using Microsoft.EntityFrameworkCore;

namespace DDDSampleProject.Infrastructure.Ef.Context;

public sealed class WriteDbContext : DbContext
{

    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
    {

    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
