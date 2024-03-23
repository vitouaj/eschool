
namespace course.api;

public interface IModuleRepository
{
    Task<List<object?>> GetAllAsync();
    Task<Module.Module> AddModuleAsync(ModuleDto dto);
    Task<object?> GetByIdAsync(string moduleId);
    Task<object?> UpdateAsync(ModuleDto moduleDto);
    Task<object?> DeleteAsync(string moduleId);

}
