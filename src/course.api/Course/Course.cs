using System.Text.Json.Serialization;

namespace course.api.Course;

public class Course
{
    public string Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public float HighestScore { get; set; }
    public float PassingScore { get; set; }
    public string? Description { get; set; }
    public bool IsValid { get; set; } = false;
    public Grade.GradeLevel GradeId { get; set; }
    public Subject.SubjectType SubjectId { get; set; }

    [JsonIgnore]
    public List<Module.Module> Modules { get; set; } = [];
}
