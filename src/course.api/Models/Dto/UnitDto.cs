namespace course.api;

public class UnitDto(string name, string? description, string moduleId)
{
    public string ModuleId { get; set; } = moduleId;
    public string Name { get; set; } = name;
    public string? Description { get; set; } = description;

}
