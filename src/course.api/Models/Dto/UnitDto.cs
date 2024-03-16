namespace course.api;

public class UnitDto(string name, string? description, int moduleId)
{
    public int ModuleId { get; set; } = moduleId;
    public string Name { get; set; } = name;
    public string? Description { get; set; } = description;

}
