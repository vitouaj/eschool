using System.Text.Json.Serialization;

namespace course.api.Module;

public class Module
{
    public string Id { get; set; }
    public string CourseId { get; set; }

    [JsonIgnore]
    public Course.Course Course { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateOnly StartedDate { get; set; }
    public DateOnly EndedDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
    public int NumberOfHours { get; set; }
    public List<Unit.Unit> Units { get; set; } = [];
}
