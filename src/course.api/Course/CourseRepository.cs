using course.api.Course;
using course.api.Utils;
using Microsoft.EntityFrameworkCore;

namespace course.api.Services;

public class CourseRepository(course.api.Data.AppDbContext context) : ICourseRepository
{
    private course.api.Data.AppDbContext db = context;
    public async Task<Course.Course> AddCourseAsync(CourseDto dto)
    {
        var newCourse = new Course.Course
        {
            Id = IDGenerator.CourseId(),
            Title = dto.Name,
            HighestScore = dto.HighestScore,
            PassingScore = dto.PassingScore,
            Description = dto.Description,
            GradeId = dto.GradeId,
            SubjectId = dto.SubjectId,
        };
        await db.Courses.AddAsync(newCourse);
        await db.SaveChangesAsync();
        return newCourse;
    }

    public async Task<object?> DeleteByIdAsync(string courseId)
    {
        var course = await db.Courses
            .FirstOrDefaultAsync(c => c.Id.Equals(courseId));

        if (course is null)
            throw new CourseNotFoundException("Course not found");
        db.Courses.Remove(course);

        await db.SaveChangesAsync();
        return new { Id = course.Id };
    }

    public async Task<object?> GetAllAsync(int pageIndex, int pageSize)
    {
        var courses = await db.Courses
        .OrderBy(c => c.Title)
        .Skip(pageSize * pageIndex)
        .Take(pageSize)
        .ToListAsync();
        return courses;
    }

    public async Task<object?> GetCourseByIdAsync(string courseId)
    {
        var course = await db.Courses
            .Include(c => c.Modules)
            .Select(s => new
            {
                s.Id,
                s.Title,
                Subject = s.SubjectId,
                Grade = s.GradeId,
                s.Description,
                Modules = s.Modules
                    .Select(m => new
                    {
                        m.Id,
                        m.Name,
                        m.Description,
                        m.StartedDate,
                        m.EndedDate,
                        Units = m.Units
                            .Select(u => new
                            {
                                u.Id,
                                u.Name,
                                u.Description,
                            }).ToList()
                    }).ToList()
            })
            .FirstOrDefaultAsync(c => c.Id.Equals(courseId));

        return course;
    }

    public async Task<object?> UpdateAsync(CourseDto dto)
    {
        var course = await db.Courses.FirstOrDefaultAsync(c => c.Id.Equals(dto.Id));
        if (course == null)
            throw new CourseNotFoundException("Course is not found");

        course.Title = dto.Name;
        course.SubjectId = dto.SubjectId;
        course.GradeId = dto.GradeId;
        course.Description = dto.Description;
        course.HighestScore = dto.HighestScore;
        course.PassingScore = dto.PassingScore;

        await db.SaveChangesAsync();
        return course;
    }
}
