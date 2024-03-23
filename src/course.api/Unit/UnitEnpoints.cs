namespace course.api.Unit;

public static class UnitEnpoints
{
    public static void MapUnit(this IEndpointRouteBuilder app)
    {
        app.MapGet("/unit/{id}", GetById);
        app.MapPost("/unit", Create);
        app.MapPut("/unit", Update);
        app.MapDelete("/unit/{id}", Delete);
    }

    static async Task<IResult> GetById(string id, IUnitRepository repository)
    {
        var unit = await repository.GetById(id);

        if (unit == null)
            return Results.BadRequest("unit is not found!");

        return Results.Ok(unit);
    }

    static async Task<IResult> Create(IUnitRepository repository, UnitDto dto)
    {
        var unit = await repository.AddUnit(dto);

        return Results.Created("/unit", unit);
    }

    static async Task<IResult> Update(IUnitRepository repository, UnitDto dto)
    {
        var updated = await repository.Update(dto);

        if (updated == null)
            return Results.BadRequest(updated);

        return Results.Ok(updated);
    }

    static async Task<IResult> Delete(IUnitRepository repository, string id)
    {
        var unitId = await repository.Delete(id);

        if (unitId == null)
            return Results.BadRequest(unitId);

        return Results.Ok(unitId);
    }
}
