namespace course.api;

public interface IUnitRepository
{
    Task<Unit> AddUnit(UnitDto unitDto);
    Task<List<object?>> GetAll();
    Task<object?> Update(UnitDto unitDto);
    Task<object?> Delete(Guid unitId);
    Task<object?> GetById(Guid unitId);
}
