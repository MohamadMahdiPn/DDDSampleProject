
using DDDSampleProject.Application.Models.CourseManagement;
using DDDSampleProject.Application.Models.PaymentManagement;
using DDDSampleProject.Application.Models.UserManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDSampleProject.Infrastructure.Ef.Configs.ReadConfigs;

internal sealed partial class ReadConfigurations :
    IEntityTypeConfiguration<CourseReadModel>,
    IEntityTypeConfiguration<CourseCatalogReadModel>,
    IEntityTypeConfiguration<CourseAttendeeReadModel>,
    IEntityTypeConfiguration<InvoiceReadModel>,
    IEntityTypeConfiguration<InstructorReadModel>,
    IEntityTypeConfiguration<LessonReadModel>,
    IEntityTypeConfiguration<UserReadModel>,
    IEntityTypeConfiguration<UserRoleReadModel>,
    IEntityTypeConfiguration<RoleReadModel>
{
    #region Invoice
    public void Configure(EntityTypeBuilder<InvoiceReadModel> builder)
    {
        builder.ToTable("Invoices");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Amount);
        builder.Property(e => e.Date);
        builder.Property(e => e.UserId);
        builder.Property(e => e.CourseId);

        builder.HasOne(e => e.User).WithMany(e => e.Invoices).HasForeignKey(i => i.UserId);
        builder.HasOne(e => e.Course).WithMany(e => e.Invoices).HasForeignKey(i => i.CourseId);
    }
    #endregion



    #region Course
    public void Configure(EntityTypeBuilder<CourseReadModel> builder)
    {
        builder.ToTable("Courses");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Title);
        builder.Property(e => e.Description);
        builder.Property(e => e.IsFree);
        builder.Property(e => e.Price);
        builder.Property(c => c.InstructorId);
        builder.HasOne(c => c.Instructor).WithMany(i => i.Courses).HasForeignKey(c => c.InstructorId);
        builder.HasMany(e => e.CourseAttendees).WithOne(e => e.Course).HasForeignKey(e => e.CourseId);
        builder.HasMany(e => e.CourseCatalogs).WithOne(e => e.Course).HasForeignKey(e => e.CourseId);





    }
    #endregion

    #region CourseCatalog
    public void Configure(EntityTypeBuilder<CourseCatalogReadModel> builder)
    {
        builder.ToTable("CourseCatalogs");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Title);
        builder.Property(e => e.Description);
        builder.Property(e => e.CourseId);

        builder.HasOne(c => c.Course).WithMany(e => e.CourseCatalogs).HasForeignKey(e => e.CourseId);
        builder.HasMany(e => e.Lessons).WithOne(e => e.CourseCatalog).HasForeignKey(e => e.CourseCatalogId);



    }
    #endregion

    #region CourseAttendee
    public void Configure(EntityTypeBuilder<CourseAttendeeReadModel> builder)
    {
        builder.ToTable("CourseAttendees");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.UserId);
        builder.Property(e => e.CourseId);

        builder.HasOne(e => e.Course).WithMany(e => e.CourseAttendees).HasForeignKey(e => e.CourseId);
        builder.HasOne(e => e.User).WithMany(e => e.CourseAttendees).HasForeignKey(e => e.UserId);


    }
    #endregion

    #region Instructor
    public void Configure(EntityTypeBuilder<InstructorReadModel> builder)
    {
        builder.ToTable("Instructors");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.FullName);
        builder.Property(e => e.Experience);
        builder.Property(e => e.Bio);
        builder.Property(e => e.Rating);

        builder.HasMany(i => i.Courses)
           .WithOne(c => c.Instructor)
           .HasForeignKey(c => c.InstructorId);

    }


    #endregion

    #region Lesson
    public void Configure(EntityTypeBuilder<LessonReadModel> builder)
    {
        builder.ToTable("Lessons");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Title);
        builder.Property(e => e.VideoUrl);
        builder.Property(e => e.CourseCatalogId);


        builder.HasOne(e => e.CourseCatalog).WithMany(e => e.Lessons).HasForeignKey(e => e.CourseCatalogId);
    }


    #endregion



    #region User
    public void Configure(EntityTypeBuilder<UserReadModel> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(e => e.Id);
        builder.Property(x => x.UserName);
        builder.Property(x => x.IsConfirmed);
        builder.Property(x => x.Password);
        builder.Property(x => x.Email);
       
        builder.HasMany(x=>x.UserRoles).WithOne(x=>x.User).HasForeignKey(x => x.UserId);
        builder.HasMany(x=>x.CourseAttendees).WithOne(x=>x.User).HasForeignKey(x=>x.UserId);
        builder.HasMany(x=>x.Invoices).WithOne(x=>x.User).HasForeignKey(x=>x.UserId);

     
    }


    #endregion

    #region UserRole
    public void Configure(EntityTypeBuilder<UserRoleReadModel> builder)
    {
        builder.ToTable("UserRole");
        builder.HasKey(e => new { e.UserId, e.RoleId });


        builder.HasOne(x => x.Role).WithMany(x=>x.UserRoles).HasForeignKey(e => e.RoleId);
        builder.HasOne(x => x.User).WithMany(x=>x.UserRoles).HasForeignKey(e => e.UserId);

    }


    #endregion

    #region Role
    public void Configure(EntityTypeBuilder<RoleReadModel> builder)
    {
        builder.ToTable("Roles");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.RoleName);

        builder.HasMany(e => e.UserRoles).WithOne(e => e.Role).HasForeignKey(x=>x.RoleId);


    }
    #endregion



}
