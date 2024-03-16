namespace course.api;

public class ModuleDto(string name, string? description, DateOnly startedDate, DateOnly endedDate, int numberOfHours, Guid courseId)
{
    public Guid CourseId { get; set; } = courseId;
    public string Name { get; set; } = name;
    public string? Description { get; set; } = description;
    public DateOnly StartedDate { get; set; } = startedDate;
    public DateOnly EndedDate { get; set; } = endedDate;
    public int NumberOfHours { get; set; } = numberOfHours;
    // public List<UnitDto> Units { get; set; } = unitDtos;
}
