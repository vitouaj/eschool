using course.api.Grade;
using course.api.Subject;

namespace course.api;

public class CourseDto(string id, string name, string? description, GradeLevel gradeId, SubjectType subjectId, float highestScore, float passingScore)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public float HighestScore { get; set; } = highestScore;
    public float PassingScore { get; set; } = passingScore;
    public Grade.GradeLevel GradeId { get; set; } = gradeId;
    public Subject.SubjectType SubjectId { get; set; } = subjectId;
    public string? Description { get; set; } = description;
}
