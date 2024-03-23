using course.api.Models;

namespace course.api;

public interface IModuleRepository
{
    Task<List<object?>> GetAllAsync();
    Task<CourseModule> AddModuleAsync(ModuleDto dto);
    Task<object?> GetByIdAsync(string moduleId);
    Task<object?> UpdateAsync(ModuleDto moduleDto);
    Task<object?> DeleteAsync(string moduleId);

}
