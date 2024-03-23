
using course.api.Data;
using course.api.Models;
using course.api.Utils;
using Microsoft.EntityFrameworkCore;

namespace course.api;

public class UnitRepository(AppDbContext context) : IUnitRepository
{
    private readonly AppDbContext db = context;
    public async Task<Unit> AddUnit(UnitDto dto)
    {
        var unit = new Unit
        {
            Id = IDGenerator.UnitId(),
            ModuleId = dto.ModuleId,
            Description = dto.Description,
            Name = dto.Name,
        };
        await db.Units.AddAsync(unit);
        await db.SaveChangesAsync();
        return unit;
    }

    public Task<object?> Delete(string unitId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<object?>> GetAll()
    {
        var units = await db.Units.ToListAsync();
        return units.Select(u => (object?)u).ToList();
    }

    public Task<object?> GetById(string unitId)
    {
        throw new NotImplementedException();
    }

    public Task<object?> Update(UnitDto unitDto)
    {
        throw new NotImplementedException();
    }
}
