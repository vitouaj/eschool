
using course.api.Data;
using Microsoft.EntityFrameworkCore;

namespace course.api;

public class UnitRepository(AppDbContext context) : IUnitRepository
{
    private readonly AppDbContext db = context;
    public async Task<Unit> AddUnit(UnitDto dto)
    {
        var unit = new Unit
        {
            Id = Guid.NewGuid(),
            ModuleId = dto.ModuleId,
            Description = dto.Description,
            Name = dto.Name,
        };
        await db.Units.AddAsync(unit);
        await db.SaveChangesAsync();
        return unit;
    }

    public Task<object?> Delete(Guid unitId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<object?>> GetAll()
    {
        var units = await db.Units.ToListAsync();
        return units.Select(u => (object?)u).ToList();
    }

    public Task<object?> GetById(Guid unitId)
    {
        throw new NotImplementedException();
    }

    public Task<object?> Update(UnitDto unitDto)
    {
        throw new NotImplementedException();
    }
}
