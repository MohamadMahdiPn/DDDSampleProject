using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Entities.PaymentManagement;
using DDDSampleProject.Domain.Entities.UserManagement;
using DDDSampleProject.Infrastructure.Ef.Configs.ReadConfigs;
using DDDSampleProject.Infrastructure.Ef.Configs.WriteConfigs;
using DDDSampleProject.Application.Models.CourseManagement;
using DDDSampleProject.Application.Models.PaymentManagement;
using DDDSampleProject.Application.Models.UserManagement;
using Microsoft.EntityFrameworkCore;
using DDDSampleProject.Abstraction.Domain;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Infrastructure.Ef.Context;

public sealed class WriteDbContext : DbContext
{
    #region Constructor
    private readonly IDomainEventDispacher _eventDispacher;
    public WriteDbContext(DbContextOptions<WriteDbContext> options, IDomainEventDispacher domainEventDispacher) : base(options)
    {
        _eventDispacher = domainEventDispacher;

    }

    #endregion

    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseCatalog> CourseCatalogs { get; set; }
    public DbSet<CourseAttendee> CourseAttendees { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Instructor> Instructors { get; set; }

    public DbSet<Invoice> Invoices { get; set; }

    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var configuration = new WriteModelConfigurations();

        modelBuilder.ApplyConfiguration<Course>(configuration);
        modelBuilder.ApplyConfiguration<CourseCatalog>(configuration);
        modelBuilder.ApplyConfiguration<CourseAttendee>(configuration);
        modelBuilder.ApplyConfiguration<Instructor>(configuration);

        modelBuilder.ApplyConfiguration<Invoice>(configuration);

        modelBuilder.ApplyConfiguration<Role>(configuration);
        modelBuilder.ApplyConfiguration<User>(configuration);
    }


    public override int SaveChanges()
    {
        var response = base.SaveChanges();
        DispachDomainEvents().GetAwaiter().GetResult();
        return response;
    }

    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        var response = base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        await DispachDomainEvents();
        return await response;
    }

    private async Task DispachDomainEvents()
    {
        var aggregarteRoots = ChangeTracker.Entries<AggregateRoot<BaseId>>()
            .Select(entry => entry.Entity)
            .Where(aggregate => aggregate.Events.Any()).ToArray();
        foreach (var aggregate in aggregarteRoots)
        {
            var events = aggregate.Events.ToArray();
            aggregate.ClearEvents();
            foreach (var @event in events)
            {
                await _eventDispacher.DispatchAsync(@event);
            }
        }
    }
}


