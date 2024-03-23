using Microsoft.EntityFrameworkCore;
using course.api.Models;
using course.api.Utils;

namespace course.api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : DbContext(options)
{
    private readonly IConfiguration Configuration = configuration;
    public DbSet<Course> Courses { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<CourseModule> Modules { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Unit> Units { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Course>()
        .HasMany(c => c.Modules)
        .WithOne(m => m.Course)
        .HasForeignKey(m => m.CourseId)
        .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<CourseModule>()
            .HasMany(m => m.Units)
            .WithOne(u => u.Module)
            .HasForeignKey(m => m.ModuleId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Grade>()
            .HasMany(g => g.Courses)
            .WithOne(c => c.Grade)
            .HasForeignKey(g => g.GradeId);

        modelBuilder.Entity<Subject>()
            .HasMany(s => s.Courses)
            .WithOne(c => c.Subject)
            .HasForeignKey(c => c.SubjectId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Grade>()
            .HasData(new List<Grade>(){
                new Grade(IDGenerator.GradeId(GradeLevel.G7), GradeLevel.G7),
                new Grade(IDGenerator.GradeId(GradeLevel.G8), GradeLevel.G8),
                new Grade(IDGenerator.GradeId(GradeLevel.G9), GradeLevel.G9),
                new Grade(IDGenerator.GradeId(GradeLevel.G10), GradeLevel.G10),
                new Grade(IDGenerator.GradeId(GradeLevel.G11), GradeLevel.G11),
                new Grade(IDGenerator.GradeId(GradeLevel.G12), GradeLevel.G12),
            });

        modelBuilder.Entity<Subject>()
            .HasData(new List<Subject>(){
                new Subject(IDGenerator.SubjectId(), "Math"),
                new Subject(IDGenerator.SubjectId(), "Physic"),
                new Subject(IDGenerator.SubjectId(), "History"),
                new Subject(IDGenerator.SubjectId(), "Biology"),
                new Subject(IDGenerator.SubjectId(), "Sport"),
                new Subject(IDGenerator.SubjectId(), "English"),
                new Subject(IDGenerator.SubjectId(), "Khmer"),
                new Subject(IDGenerator.SubjectId(), "Utility"),
                new Subject(IDGenerator.SubjectId(), "Chemistry"),
                new Subject(IDGenerator.SubjectId(), "Earth"),
                new Subject(IDGenerator.SubjectId(), "Geolography"),
                new Subject(IDGenerator.SubjectId(), "Chinese")
            });
    }
}
