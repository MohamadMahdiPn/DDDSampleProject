using DDDSampleProject.Infrastructure.Ef.Models.CourseManagement;
using DDDSampleProject.Infrastructure.Ef.Models.PaymentManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDSampleProject.Infrastructure.Ef.Configs.ReadConfigs;

internal sealed partial class ReadConfigurations :
    IEntityTypeConfiguration<CourseReadModel>,
    IEntityTypeConfiguration<CourseCatalogReadModel>,
    IEntityTypeConfiguration<CourseAttendeeReadModel>,
    IEntityTypeConfiguration<InvoiceReadModel>,
    IEntityTypeConfiguration<InstructorReadModel>,
    IEntityTypeConfiguration<LessonReadModel>
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
        builder.Property(e => e.InstructorId);

        builder.HasOne(e => e.Instructor).WithMany(e => e.Courses).HasForeignKey(e=>e.InstructorId);
        builder.HasMany(e=>e.CourseAttendees).WithOne(e=>e.Course).HasForeignKey(e=>e.CourseId); 
        builder.HasMany(e=>e.CourseCatalogs).WithOne(e=>e.Course).HasForeignKey(e=>e.CourseId);





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
      
        builder.HasOne(c => c.Course).WithMany(e=>e.CourseCatalogs).HasForeignKey(e=>e.CourseId);
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

        builder.HasOne(e => e.Course).WithMany(e=>e.CourseAttendees).HasForeignKey(e=>e.CourseId);
        builder.HasOne(e=>e.User).WithMany(e=>e.CourseAttendees).HasForeignKey(e=> e.UserId);


    }
    #endregion

    #region Instructor
    public void Configure(EntityTypeBuilder<InstructorReadModel> builder)
    {
        builder.ToTable("Instructors");
        builder.HasKey(e => e.Id);
        builder.HasKey(e => e.FullName);
        builder.HasKey(e => e.Experience);
        builder.HasKey(e => e.Bio);
        builder.HasKey(e => e.Rating);
       
        builder.HasMany(e=>e.Courses).WithOne(e=>e.Instructor).HasForeignKey(e=>e.InstructorId);

    }


    #endregion

    #region Lesson
    public void Configure(EntityTypeBuilder<LessonReadModel> builder)
    {
        builder.ToTable("Lessons");
        builder.HasKey(e => e.Id);
        builder.HasKey(e => e.Title);
        builder.HasKey(e => e.VideoUrl);
        builder.HasKey(e => e.CourseCatalogId);


        builder.HasOne(e => e.CourseCatalog).WithMany(e => e.Lessons).HasForeignKey(e => e.CourseCatalogId);
    }
    #endregion

}
