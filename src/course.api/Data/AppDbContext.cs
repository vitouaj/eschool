using Microsoft.EntityFrameworkCore;

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
                new Grade(1, 7),
                new Grade(2, 8),
                new Grade(3, 9),
                new Grade(4, 10),
                new Grade(5, 11),
                new Grade(6, 12)
            });

        modelBuilder.Entity<Subject>()
            .HasData(new List<Subject>(){
                new Subject(1, "Math"),
                new Subject(2, "Physic"),
                new Subject(3, "History"),
                new Subject(4, "Biology"),
                new Subject(5, "Sport"),
                new Subject(6, "English"),
                new Subject(7, "Khmer"),
                new Subject(8, "Utility"),
                new Subject(9, "Chemistry"),
                new Subject(10, "Earth"),
                new Subject(11, "Geolography"),
                new Subject(12, "Chinese")
            });
    }
}
