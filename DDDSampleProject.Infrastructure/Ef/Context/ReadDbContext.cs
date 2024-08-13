using DDDSampleProject.Infrastructure.Ef.Configs.ReadConfigs;
using DDDSampleProject.Application.Models.CourseManagement;
using DDDSampleProject.Application.Models.PaymentManagement;
using DDDSampleProject.Application.Models.UserManagement;
using Microsoft.EntityFrameworkCore;

namespace DDDSampleProject.Infrastructure.Ef.Context;

public sealed class ReadDbContext:DbContext
{

	public ReadDbContext(DbContextOptions<ReadDbContext> options):base(options)
	{

	}


    public DbSet<CourseReadModel> Courses { get; set; }
    public DbSet<CourseCatalogReadModel> CourseCatalogs { get; set; }
    public DbSet<CourseAttendeeReadModel> CourseAttendees { get; set; }
    public DbSet<LessonReadModel> Lessons { get; set; }
    public DbSet<InstructorReadModel> Instructors { get; set; }

    public DbSet<InvoiceReadModel> Invoices { get; set; }

    public DbSet<RoleReadModel> Roles { get; set; }
    public DbSet<UserReadModel> Users { get; set; }
    public DbSet<UserRoleReadModel> UserRoles { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        var configuration = new ReadConfigurations();

        modelBuilder.ApplyConfiguration<CourseReadModel>(configuration);
        modelBuilder.ApplyConfiguration<CourseCatalogReadModel>(configuration);
        modelBuilder.ApplyConfiguration<CourseAttendeeReadModel>(configuration);
        modelBuilder.ApplyConfiguration<InstructorReadModel>(configuration);

        modelBuilder.ApplyConfiguration<InvoiceReadModel>(configuration);

        modelBuilder.ApplyConfiguration<RoleReadModel>(configuration);
        modelBuilder.ApplyConfiguration<UserReadModel>(configuration);
    }
}
