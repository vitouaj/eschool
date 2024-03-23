using course.api.Grade;

namespace course.api.Models;

public class Grade(string id, GradeLevel level)
{
    public string Id { get; set; } = id;
    public GradeLevel Level { get; set; } = level;
    public List<Course> Courses { get; set; } = [];
}
