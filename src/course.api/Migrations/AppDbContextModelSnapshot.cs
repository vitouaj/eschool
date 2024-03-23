﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using course.api.Data;

#nullable disable

namespace course.api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("course.api.Models.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("GradeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("HighestScore")
                        .HasColumnType("real");

                    b.Property<bool>("IsValid")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("PassingScore")
                        .HasColumnType("real");

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("course.api.Models.CourseModule", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateOnly>("EndedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfHours")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("StartedDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("course.api.Models.Grade", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = "G07",
                            Level = 7
                        },
                        new
                        {
                            Id = "G08",
                            Level = 8
                        },
                        new
                        {
                            Id = "G09",
                            Level = 9
                        },
                        new
                        {
                            Id = "G10",
                            Level = 10
                        },
                        new
                        {
                            Id = "G11",
                            Level = 11
                        },
                        new
                        {
                            Id = "G12",
                            Level = 12
                        });
                });

            modelBuilder.Entity("course.api.Models.Subject", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = "Su-20240323ed475",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8456),
                            Description = "",
                            Name = "Math",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8456)
                        },
                        new
                        {
                            Id = "Su-202403232e3b3",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8473),
                            Description = "",
                            Name = "Physic",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8474)
                        },
                        new
                        {
                            Id = "Su-20240323e3216",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8487),
                            Description = "",
                            Name = "History",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8487)
                        },
                        new
                        {
                            Id = "Su-202403233fad3",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8499),
                            Description = "",
                            Name = "Biology",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8499)
                        },
                        new
                        {
                            Id = "Su-202403236376d",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8512),
                            Description = "",
                            Name = "Sport",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8512)
                        },
                        new
                        {
                            Id = "Su-202403239ad01",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8526),
                            Description = "",
                            Name = "English",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8526)
                        },
                        new
                        {
                            Id = "Su-20240323e84c0",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8537),
                            Description = "",
                            Name = "Khmer",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8538)
                        },
                        new
                        {
                            Id = "Su-202403234da51",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8549),
                            Description = "",
                            Name = "Utility",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8550)
                        },
                        new
                        {
                            Id = "Su-202403238bec7",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8561),
                            Description = "",
                            Name = "Chemistry",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8562)
                        },
                        new
                        {
                            Id = "Su-202403239d3f9",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8575),
                            Description = "",
                            Name = "Earth",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8575)
                        },
                        new
                        {
                            Id = "Su-20240323270a4",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8587),
                            Description = "",
                            Name = "Geolography",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8587)
                        },
                        new
                        {
                            Id = "Su-202403232b44e",
                            CreatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8599),
                            Description = "",
                            Name = "Chinese",
                            UpdatedAt = new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8599)
                        });
                });

            modelBuilder.Entity("course.api.Models.Unit", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ModuleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("course.api.Models.Course", b =>
                {
                    b.HasOne("course.api.Models.Grade", "Grade")
                        .WithMany("Courses")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("course.api.Models.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("course.api.Models.CourseModule", b =>
                {
                    b.HasOne("course.api.Models.Course", "Course")
                        .WithMany("Modules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("course.api.Models.Unit", b =>
                {
                    b.HasOne("course.api.Models.CourseModule", "Module")
                        .WithMany("Units")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("course.api.Models.Course", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("course.api.Models.CourseModule", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("course.api.Models.Grade", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("course.api.Models.Subject", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
