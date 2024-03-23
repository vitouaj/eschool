using Microsoft.EntityFrameworkCore;

namespace course.api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : DbContext(options)
{
    private readonly IConfiguration Configuration = configuration;
    public DbSet<Course.Course> Courses { get; set; }
    public DbSet<Grade.Grade> Grades { get; set; }
    public DbSet<Module.Module> Modules { get; set; }
    public DbSet<Subject.Subject> Subjects { get; set; }
    public DbSet<Unit.Unit> Units { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Grade.Grade>()
            .Property(g => g.Level)
            .HasConversion<string>();

        builder.Entity<Grade.Grade>()
            .HasKey(g => g.Id);

        builder.Entity<Subject.Subject>()
            .Property(s => s.Type)
            .HasConversion<string>();

        builder.Entity<Subject.Subject>()
            .HasKey(e => e.Id);


        builder.Entity<Course.Course>()
            .Property(c => c.SubjectId)
            .HasConversion<string>();

        builder.Entity<Course.Course>()
            .Property(c => c.GradeId)
            .HasConversion<string>();

        builder.Entity<Course.Course>()
            .HasMany(c => c.Modules)
            .WithOne(c => c.Course)
            .HasForeignKey(c => c.CourseId);



        builder.Entity<Module.Module>()
            .HasMany(c => c.Units)
            .WithOne(c => c.Module)
            .HasForeignKey(c => c.ModuleId);


        builder.Entity<Grade.Grade>()
            .HasData(
                Enum.GetValues(typeof(Grade.GradeLevel))
                    .Cast<Grade.GradeLevel>()
                    .Select(g => new Grade.Grade
                    {
                        Id = (int)g,
                        Level = g
                    })
            );

        builder.Entity<Subject.Subject>()
            .HasData(
                Enum.GetValues(typeof(Subject.SubjectType))
                    .Cast<Subject.SubjectType>()
                    .Select(t => new Subject.Subject
                    {
                        Id = (int)t,
                        Type = t
                    })
            );
    }
}
