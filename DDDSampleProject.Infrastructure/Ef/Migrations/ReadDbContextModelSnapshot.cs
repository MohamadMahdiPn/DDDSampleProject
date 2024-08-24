﻿// <auto-generated />
using System;
using DDDSampleProject.Infrastructure.Ef.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDDSampleProject.Infrastructure.Ef.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    partial class ReadDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.CourseAttendeeReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseAttendees", (string)null);
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.CourseCatalogReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseCatalogs", (string)null);
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.CourseReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.InstructorReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.LessonReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseCatalogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseCatalogId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.PaymentManagement.InvoiceReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Invoices", (string)null);
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.UserManagement.RoleReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.UserManagement.UserReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.UserManagement.UserRoleReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.CourseAttendeeReadModel", b =>
                {
                    b.HasOne("DDDSampleProject.Application.Models.CourseManagement.CourseReadModel", "Course")
                        .WithMany("CourseAttendees")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DDDSampleProject.Application.Models.UserManagement.UserReadModel", "User")
                        .WithMany("CourseAttendees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.CourseCatalogReadModel", b =>
                {
                    b.HasOne("DDDSampleProject.Application.Models.CourseManagement.CourseReadModel", "Course")
                        .WithMany("CourseCatalogs")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.CourseReadModel", b =>
                {
                    b.HasOne("DDDSampleProject.Application.Models.CourseManagement.InstructorReadModel", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.LessonReadModel", b =>
                {
                    b.HasOne("DDDSampleProject.Application.Models.CourseManagement.CourseCatalogReadModel", "CourseCatalog")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseCatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseCatalog");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.PaymentManagement.InvoiceReadModel", b =>
                {
                    b.HasOne("DDDSampleProject.Application.Models.CourseManagement.CourseReadModel", "Course")
                        .WithMany("Invoices")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DDDSampleProject.Application.Models.UserManagement.UserReadModel", "User")
                        .WithMany("Invoices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.UserManagement.UserRoleReadModel", b =>
                {
                    b.HasOne("DDDSampleProject.Application.Models.UserManagement.RoleReadModel", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DDDSampleProject.Application.Models.UserManagement.UserReadModel", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.CourseCatalogReadModel", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.CourseReadModel", b =>
                {
                    b.Navigation("CourseAttendees");

                    b.Navigation("CourseCatalogs");

                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.CourseManagement.InstructorReadModel", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.UserManagement.RoleReadModel", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("DDDSampleProject.Application.Models.UserManagement.UserReadModel", b =>
                {
                    b.Navigation("CourseAttendees");

                    b.Navigation("Invoices");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
