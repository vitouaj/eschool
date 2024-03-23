namespace course.api;

public class CourseDto(string id, string name, string? description, string gradeId, string subjectId, float highestScore, float passingScore)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public float HighestScore { get; set; } = highestScore;
    public float PassingScore { get; set; } = passingScore;
    public string GradeId { get; set; } = gradeId;
    public string SubjectId { get; set; } = subjectId;
    public string? Description { get; set; } = description;
}
