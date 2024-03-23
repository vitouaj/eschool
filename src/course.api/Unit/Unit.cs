using System.Text.Json.Serialization;

namespace course.api.Unit;

public class Unit
{
    public string Id { get; set; }
    public string ModuleId { get; set; }
    [JsonIgnore]
    public Module.Module Module { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Unit() { }
}
