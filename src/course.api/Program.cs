using course.api.Data;
using course.api.Apis;
using course.api.Services;
using course.api;
using course.api.Course;
using course.api.Unit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.UseDateOnlyTimeOnlyStringConverters());

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IUnitRepository, UnitRepository>();
builder.Services.AddScoped<IModuleRepository, ModuleRepository>();
builder.Services.AddDateOnlyTimeOnlyStringConverters();
builder.Services.AddDbContext<course.api.Data.AppDbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DefaultModelsExpandDepth(-1);
    });
}

app.UseHttpsRedirection();

app.MapGroup("/api/v1")
    .WithTags("Course Resourse")
    .MapCourse();

app.MapGroup("/api/v1")
    .WithTags("Module Resourse")
    .MapModule();

app.MapGroup("/api/v1")
    .WithTags("Unit Resourse")
    .MapUnit();

app.Run();