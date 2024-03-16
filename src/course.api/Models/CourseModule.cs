using System.Text.Json.Serialization;

namespace course.api;

public class CourseModule
{
    public int Id { get; set; }
    public Guid CourseId { get; set; }
    
    [JsonIgnore]
    public Course Course { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateOnly StartedDate { get; set; }
    public DateOnly EndedDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public int NumberOfHours { get; set; }
    public List<Unit> Units { get; set; } = [];
}
