

using Microsoft.EntityFrameworkCore;

namespace course.api;

public class ModuleRepository(course.api.Data.AppDbContext context) : IModuleRepository
{
    private readonly course.api.Data.AppDbContext db = context;
    public async Task<Module.Module> AddModuleAsync(ModuleDto dto)
    {
        var module = new Module.Module
        {
            CourseId = dto.CourseId,
            Name = dto.Name,
            Description = dto.Description,
            StartedDate = dto.StartedDate,
            EndedDate = dto.EndedDate,
            NumberOfHours = dto.NumberOfHours
        };

        await db.Modules.AddAsync(module);
        await db.SaveChangesAsync();
        return module;
    }

    public Task<object?> DeleteAsync(string moduleId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<object?>> GetAllAsync()
    {
        var modules = await db.Modules.ToListAsync();

        return modules.Select(c => (object?)c).ToList();
    }

    public Task<object?> GetByIdAsync(string moduleId)
    {
        throw new NotImplementedException();
    }

    public Task<object?> UpdateAsync(ModuleDto moduleDto)
    {
        throw new NotImplementedException();
    }
}
