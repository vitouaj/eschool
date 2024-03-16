using System.Text.Json.Serialization;

namespace course.api;

public class Unit
{
    public Unit() { }
    public Guid Id { get; set; }
    public int ModuleId { get; set; }
    [JsonIgnore]
    public CourseModule Module { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
