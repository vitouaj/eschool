using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace course.api.Apis;

public static class CourseEnpoints
{
    public static void MapCourse(this IEndpointRouteBuilder app)
    {
        app.MapGet("/course/{id}", GetCourseById);
        app.MapPost("/course", CreateCourse);
        app.MapPut("/course", UpdateCourse);
        app.MapDelete("/course/{id}", DeleteCourse);
        app.MapGet("/", GetAllCourses);
    }

    private static async Task<IResult> GetAllCourses([FromQuery] int pageIndex, [FromQuery] int pageSize, ICourseRepository repository)
    {
        var courses = await repository.GetAllAsync(pageIndex, pageSize);
        return Results.Ok(courses);
    }

    static async Task<IResult> GetCourseById(string id, ICourseRepository repository)
    {
        var course = await repository.GetCourseByIdAsync(id);

        if (course == null)
            return Results.BadRequest("Course is not found!");

        return Results.Ok(course);
    }

    static async Task<IResult> CreateCourse(ICourseRepository repository, CourseDto dto)
    {
        var course = await repository.AddCourseAsync(dto);

        return Results.Created("/course", course);
    }

    static async Task<IResult> UpdateCourse(ICourseRepository repository, CourseDto dto)
    {
        var updated = await repository.UpdateAsync(dto);

        if (updated == null)
            return Results.BadRequest(updated);

        return Results.Ok(updated);
    }

    static async Task<IResult> DeleteCourse(ICourseRepository repository, string id)
    {
        var courseId = await repository.DeleteByIdAsync(id);

        if (courseId == null)
            return Results.BadRequest(courseId);

        return Results.Ok(courseId);
    }
}
