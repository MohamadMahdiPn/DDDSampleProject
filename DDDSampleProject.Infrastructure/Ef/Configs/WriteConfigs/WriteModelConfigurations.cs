using DDDSampleProject.Domain.Entities.CourseManagement;
using DDDSampleProject.Domain.Entities.PaymentManagement;
using DDDSampleProject.Domain.Entities.UserManagement;
using DDDSampleProject.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DDDSampleProject.Infrastructure.Ef.Configs.WriteConfigs;

internal sealed class WriteModelConfigurations :
    IEntityTypeConfiguration<Course>,
    IEntityTypeConfiguration<CourseAttendee>,
    IEntityTypeConfiguration<CourseCatalog>,
    IEntityTypeConfiguration<Lesson>,
    IEntityTypeConfiguration<Instructor>,
    IEntityTypeConfiguration<User>,
    IEntityTypeConfiguration<UserRole>,
    IEntityTypeConfiguration<Role>,
    IEntityTypeConfiguration<Invoice>
{
    private ValueConverter idConverter = new ValueConverter<BaseId, Guid>(id => id.Value, id => new BaseId(id));
    private ValueConverter titleConverter = new ValueConverter<Title, string>(title => title.Value, title => new Title(title));
    private ValueConverter descriptionConverter = new ValueConverter<Description, string>(des => des.Value, des => new Description(des));




    #region Course
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        var priceConverter = new ValueConverter<Price, decimal>(price => price.Value, price => new Price(price));

        builder.ToTable("Courses");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).HasConversion(idConverter);
        builder.Property(typeof(Title), "_title").HasConversion(titleConverter).HasColumnName("Title").IsRequired();
        builder.Property(typeof(Description), "_description").HasConversion(descriptionConverter).HasColumnName("Description");
        builder.Property(typeof(bool), "_isFree").HasColumnName("IsFree");
        builder.Property(typeof(Price), "_price").HasConversion(priceConverter).HasColumnName("Price").IsRequired();
        builder.Property(typeof(BaseId), "_instructorId").HasConversion(idConverter).HasColumnName("InstructorId");

        builder.HasOne<Instructor>().WithMany().HasForeignKey("_instructorId").IsRequired();
        builder.HasMany(typeof(CourseAttendee), "_courseAttendees")
            .WithOne()
            .HasForeignKey("_userId");

    }
    #endregion

    #region Catalog
    public void Configure(EntityTypeBuilder<CourseCatalog> builder)
    {
        builder.ToTable("CourseCatalogs");
        builder.HasKey(cc => cc.Id);
        builder.Property(cc => cc.Id)
            .HasConversion(idConverter);

        builder.Property(typeof(Title), "_title")
        .HasConversion(titleConverter)
        .HasColumnName("Title")
        .IsRequired();

        builder.Property(typeof(Description), "_description")
                .HasConversion(descriptionConverter)
                .HasColumnName("Description")
                .IsRequired();

        builder.Property(typeof(BaseId), "_courseId")
            .HasConversion(idConverter)
            .HasColumnName("CourseId");

        builder.HasOne<Course>()
            .WithMany()
            .HasForeignKey("_courseId")
            .IsRequired();

        builder.HasMany(typeof(Lesson), "_lessons")
            .WithOne()
            .HasForeignKey("_courseCatalogId")
            .IsRequired();


    }
    #endregion

    #region Instructor
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        var fullNameConverter = new ValueConverter<FullName, string>(fullName => fullName.Value, fullName => new FullName(fullName));
        var bioConverter = new ValueConverter<Biography, string>(bio => bio.Value, bio => new Biography(bio));

        builder.ToTable("Instructors");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).HasConversion(idConverter);

        builder.Property(typeof(FullName), "_fullName")
       .HasConversion(fullNameConverter)
       .HasColumnName("FullName")
       .IsRequired();


        builder.Property(typeof(Biography), "_biography")
          .HasConversion(bioConverter)
          .HasColumnName("Biography")
          .IsRequired();
        builder.Property(typeof(double), "_rating").HasColumnName("Rating");
        builder.Property(typeof(int), "_experience").HasColumnName("Experience");

        builder.HasMany(typeof(Course), "_courses").WithOne().HasForeignKey("_instructorId");
    }
    #endregion

    #region Lesson
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        var urlConverter = new ValueConverter<VideoUrl, string>(price => price.Value, price => new VideoUrl(price));


        builder.ToTable("Lessons");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).HasConversion(idConverter);
        builder.Property(typeof(Title), "_title").HasConversion(titleConverter).HasColumnName("Title").IsRequired();
        builder.Property(typeof(VideoUrl), "_videoUrl").HasConversion(urlConverter).HasColumnName("VideoURL").IsRequired();
        builder.Property(typeof(BaseId), "_courseCatalogId").HasConversion(idConverter).HasColumnName("CourseCatalogId");
        builder.HasOne<CourseCatalog>().WithMany().HasForeignKey("_courseCatalogId").IsRequired();



    }
    #endregion

    #region CourseAttendee
    public void Configure(EntityTypeBuilder<CourseAttendee> builder)
    {
        builder.ToTable("CourseAttendees");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).HasConversion(idConverter);
        builder.Property(typeof(BaseId), "_userId").HasConversion(idConverter).HasColumnName("UserId");
        builder.Property(typeof(BaseId), "_courseId").HasConversion(idConverter).HasColumnName("CourseId");

        builder.HasOne<User>().WithMany().HasForeignKey("_userId").IsRequired();
        builder.HasOne<Course>().WithMany().HasForeignKey("_courseId").IsRequired();

    }


    #endregion



    #region User
    public void Configure(EntityTypeBuilder<User> builder)
    {
        var userNameConverter = new ValueConverter<UserName, string>(un => un.Value, un => new UserName(un));
        var passwordConverter = new ValueConverter<Password, string>(p => p.Value, p => new Password(p));
        var emailConverter = new ValueConverter<Email, string>(e => e.Value, e => new Email(e));

        builder.ToTable("Users");
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id).HasConversion(idConverter);
        builder.Property(typeof(UserName), "_username").HasConversion(userNameConverter).HasColumnName("Username").IsRequired();
        builder.Property(typeof(Password), "_password").HasConversion(passwordConverter).HasColumnName("Password").IsRequired();
        builder.Property(typeof(Email), "_email").HasConversion(emailConverter).HasColumnName("Email").IsRequired();
        builder.Property(typeof(bool), "_isConfirmed").HasColumnName("IsConfirmed");

        builder.HasMany(typeof(CourseAttendee), "_courseAttendes")
            .WithOne()
            .HasForeignKey("_userId");

        builder.HasMany(typeof(UserRole), "_userRoles").WithOne().HasForeignKey("_userId");


    }
    #endregion

    #region Role
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        var roleNameConverter = new ValueConverter<RoleName, string>(rn => rn.Value, rn => new RoleName(rn));

        builder.ToTable("Roles");
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Id).HasConversion(idConverter);
        builder.Property(typeof(RoleName), "_roleName").HasConversion(roleNameConverter).HasColumnName("RoleName").IsRequired();

        builder.HasMany(typeof(UserRole), "_userRoles").WithOne().HasForeignKey("_roleId");


    }
    #endregion

    #region UserRole
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("UserRoles");
        builder.HasKey("_userId", "_roleId");

        builder.Property(typeof(BaseId), "_userId").HasConversion(idConverter).HasColumnName("UserId").IsRequired();
        builder.Property(typeof(BaseId), "_roleId").HasConversion(idConverter).HasColumnName("RoleId").IsRequired();

        builder.HasOne<User>().WithMany("_userRoles").HasForeignKey("_userId");
        builder.HasOne<Role>().WithMany("_userRoles").HasForeignKey("_roleId");


    }
    #endregion



    #region Invoice
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        var amountConverter = new ValueConverter<Amount, decimal>(a => a.Value, a => new Amount(a));

        builder.ToTable("Invoices");
        builder.HasKey(i => i.Id);

        builder.Property(i => i.Id).HasConversion(idConverter);
        builder.Property(typeof(Amount), "_amount").HasConversion(amountConverter).HasColumnName("Amount").IsRequired();
        builder.Property(typeof(DateTime), "_date").HasColumnName("Date");
        builder.Property("_userId").HasConversion(idConverter).HasColumnName("UserId").IsRequired();
        builder.Property("_courseId").HasConversion(idConverter).HasColumnName("CourseId").IsRequired();

        builder.HasOne<User>().WithMany().HasForeignKey("_userId");
        builder.HasOne<Course>().WithMany().HasForeignKey("_courseId");


    }
    #endregion

}

