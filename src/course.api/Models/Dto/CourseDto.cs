namespace course.api;

public class CourseDto(Guid id, string name, string? description, int gradeId, int subjectId, float highestScore, float passingScore)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public float HighestScore { get; set; } = highestScore;
    public float PassingScore { get; set; } = passingScore;
    public int GradeId { get; set; } = gradeId;
    public int SubjectId { get; set; } = subjectId;
    public string? Description { get; set; } = description;
}
