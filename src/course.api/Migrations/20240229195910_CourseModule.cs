using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace course.api.Migrations
{
    /// <inheritdoc />
    public partial class CourseModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7780), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7787), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7788), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7790), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7792), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7795), new DateTime(2024, 2, 29, 19, 59, 10, 166, DateTimeKind.Utc).AddTicks(7795) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4404), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4407), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4408), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4409), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4411), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4412), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4412), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4413), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4414), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4415), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4416), new DateTime(2024, 2, 29, 19, 42, 1, 132, DateTimeKind.Utc).AddTicks(4417) });
        }
    }
}
