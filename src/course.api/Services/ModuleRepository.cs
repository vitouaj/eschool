

using course.api.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace course.api;

public class ModuleRepository(AppDbContext context) : IModuleRepository
{
    private readonly AppDbContext db = context;
    public async Task<CourseModule> AddModuleAsync(ModuleDto dto)
    {
        var module = new CourseModule
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

    public Task<object?> DeleteAsync(Guid moduleId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<object?>> GetAllAsync()
    {
        var modules = await db.Modules.ToListAsync();

        return modules.Select(c => (object?)c).ToList();
    }

    public Task<object?> GetByIdAsync(Guid moduleId)
    {
        throw new NotImplementedException();
    }

    public Task<object?> UpdateAsync(ModuleDto moduleDto)
    {
        throw new NotImplementedException();
    }
}
