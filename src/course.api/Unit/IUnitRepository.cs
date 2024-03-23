
namespace course.api.Unit;

public interface IUnitRepository
{
    Task<Unit> AddUnit(UnitDto unitDto);
    Task<List<object?>> GetAll();
    Task<object?> Update(UnitDto unitDto);
    Task<object?> Delete(string unitId);
    Task<object?> GetById(string unitId);
}
