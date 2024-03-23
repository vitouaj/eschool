namespace course.api;

public static class ModuleEnpoints
{
    public static void MapModule(this IEndpointRouteBuilder app)
    {

        app.MapGet("/module/{id}", GetById);
        app.MapPost("/module", Create);
        app.MapPut("/module", Update);
        app.MapDelete("/module/{id}", Delete);
    }


    static async Task<IResult> GetById(string id, IModuleRepository repository)
    {
        var module = await repository.GetByIdAsync(id);

        if (module == null)
            return Results.BadRequest("module is not found!");

        return Results.Ok(module);
    }

    static async Task<IResult> Create(IModuleRepository repository, ModuleDto dto)
    {
        var module = await repository.AddModuleAsync(dto);

        return Results.Created("/module", module);
    }

    static async Task<IResult> Update(IModuleRepository repository, ModuleDto dto)
    {
        var updated = await repository.UpdateAsync(dto);

        if (updated == null)
            return Results.BadRequest(updated);

        return Results.Ok(updated);
    }

    static async Task<IResult> Delete(IModuleRepository repository, string id)
    {
        var moduleId = await repository.DeleteAsync(id);

        if (moduleId == null)
            return Results.BadRequest(moduleId);

        return Results.Ok(moduleId);
    }
}
