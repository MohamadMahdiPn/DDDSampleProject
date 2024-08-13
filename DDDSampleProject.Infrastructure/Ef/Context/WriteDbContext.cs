using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Entities.PaymentManagement;
using DDDSampleProject.Domain.Entities.UserManagement;
using DDDSampleProject.Infrastructure.Ef.Configs.ReadConfigs;
using DDDSampleProject.Infrastructure.Ef.Configs.WriteConfigs;
using DDDSampleProject.Application.Models.CourseManagement;
using DDDSampleProject.Application.Models.PaymentManagement;
using DDDSampleProject.Application.Models.UserManagement;
using Microsoft.EntityFrameworkCore;

namespace DDDSampleProject.Infrastructure.Ef.Context;

public sealed class WriteDbContext : DbContext
{

    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
    {

    }

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
}
