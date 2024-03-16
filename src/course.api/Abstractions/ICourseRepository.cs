namespace course.api;

public interface ICourseRepository
{
    Task<Course> AddCourseAsync(CourseDto course);
    Task<object?> GetCourseByIdAsync(Guid guid);
    Task<object?> DeleteByIdAsync(Guid guid);
    Task<object?> UpdateAsync(CourseDto course);
    Task<object?> GetAllAsync(int pageIndex, int pageSize);
}
