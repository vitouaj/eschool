﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using course.api.Data;

#nullable disable

namespace course.api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240229194201_ModelReference")]
    partial class ModelReference
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("course.api.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("GradeId")
                        .HasColumnType("integer");

                    b.Property<float>("HighestScore")
                        .HasColumnType("real");

                    b.Property<bool>("IsValid")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("PassingScore")
                        .HasColumnType("real");

                    b.Property<int>("SubjectId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("course.api.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Level = 7
                        },
                        new
                        {
                            Id = 2,
                            Level = 8
                        },
                        new
                        {
                            Id = 3,
                            Level = 9
                        },
                        new
                        {
                            Id = 4,
                            Level = 10
                        },
                        new
                        {
                            Id = 5,
                            Level = 11
                        },
                        new
                        {
                            Id = 6,
                            Level = 12
                        });
                });

            modelBuilder.Entity("course.api.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uuid");

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

            modelBuilder.Entity("course.api.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

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
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4404),
                            Description = "",
                            Name = "Math",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4406)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4407),
                            Description = "",
                            Name = "Physic",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4408)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4408),
                            Description = "",
                            Name = "History",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4408)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4409),
                            Description = "",
                            Name = "Biology",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4409)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4410),
                            Description = "",
                            Name = "Sport",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4410)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4411),
                            Description = "",
                            Name = "English",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4411)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4412),
                            Description = "",
                            Name = "Khmer",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4412)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4412),
                            Description = "",
                            Name = "Utility",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4413)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4413),
                            Description = "",
                            Name = "Chemistry",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4413)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4414),
                            Description = "",
                            Name = "Earth",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4415)
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4415),
                            Description = "",
                            Name = "Geolography",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4415)
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4416),
                            Description = "",
                            Name = "Chinese",
                            UpdatedAt = new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4417)
                        });
                });

            modelBuilder.Entity("course.api.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("course.api.Course", b =>
                {
                    b.HasOne("course.api.Grade", "Grade")
                        .WithMany("Courses")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("course.api.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("course.api.Module", b =>
                {
                    b.HasOne("course.api.Course", "Course")
                        .WithMany("Modules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("course.api.Unit", b =>
                {
                    b.HasOne("course.api.Module", "Module")
                        .WithMany("Units")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("course.api.Course", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("course.api.Grade", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("course.api.Module", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("course.api.Subject", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}