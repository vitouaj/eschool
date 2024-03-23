namespace course.api.Models;

public class Subject(string id, string name)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public List<Course> Courses { get; set; }
}
