﻿using System.Text.Json.Serialization;

namespace course.api.Models;

public class Course
{
    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public float HighestScore { get; set; }
    public float PassingScore { get; set; }
    public string? Description { get; set; }
    public bool IsValid { get; set; } = false;
    public string GradeId { get; set; }
    [JsonIgnore]
    public Grade Grade { get; set; }
    public string SubjectId { get; set; }
    [JsonIgnore]
    public Subject Subject { get; set; }
    [JsonIgnore]
    public List<CourseModule> Modules { get; set; } = [];
}
