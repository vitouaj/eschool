namespace course.api.Course;

public interface ICourseRepository
{
    Task<Course> AddCourseAsync(CourseDto course);
    Task<object?> GetCourseByIdAsync(string courseId);
    Task<object?> DeleteByIdAsync(string courseId);
    Task<object?> UpdateAsync(CourseDto course);
    Task<object?> GetAllAsync(int pageIndex, int pageSize);
}
