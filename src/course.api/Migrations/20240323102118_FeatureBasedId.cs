using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace course.api.Migrations
{
    /// <inheritdoc />
    public partial class FeatureBasedId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HighestScore = table.Column<float>(type: "real", nullable: false),
                    PassingScore = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsValid = table.Column<bool>(type: "boolean", nullable: false),
                    GradeId = table.Column<string>(type: "text", nullable: false),
                    SubjectId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CourseId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfHours = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ModuleId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "Level" },
                values: new object[,]
                {
                    { "G07", 7 },
                    { "G08", 8 },
                    { "G09", 9 },
                    { "G10", 10 },
                    { "G11", 11 },
                    { "G12", 12 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "Su-20240323270a4", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8587), "", "Geolography", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8587) },
                    { "Su-202403232b44e", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8599), "", "Chinese", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8599) },
                    { "Su-202403232e3b3", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8473), "", "Physic", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8474) },
                    { "Su-202403233fad3", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8499), "", "Biology", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8499) },
                    { "Su-202403234da51", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8549), "", "Utility", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8550) },
                    { "Su-202403236376d", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8512), "", "Sport", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8512) },
                    { "Su-202403238bec7", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8561), "", "Chemistry", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8562) },
                    { "Su-202403239ad01", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8526), "", "English", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8526) },
                    { "Su-202403239d3f9", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8575), "", "Earth", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8575) },
                    { "Su-20240323e3216", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8487), "", "History", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8487) },
                    { "Su-20240323e84c0", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8537), "", "Khmer", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8538) },
                    { "Su-20240323ed475", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8456), "", "Math", new DateTime(2024, 3, 23, 10, 21, 18, 68, DateTimeKind.Utc).AddTicks(8456) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_GradeId",
                table: "Courses",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SubjectId",
                table: "Courses",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CourseId",
                table: "Modules",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_ModuleId",
                table: "Units",
                column: "ModuleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
