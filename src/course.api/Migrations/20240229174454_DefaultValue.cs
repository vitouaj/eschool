using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace course.api.Migrations
{
    /// <inheritdoc />
    public partial class DefaultValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "Level" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 2, 8 },
                    { 3, 9 },
                    { 4, 10 },
                    { 5, 11 },
                    { 6, 12 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7189), "", "Math", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7191) },
                    { 2, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7192), "", "Physic", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7192) },
                    { 3, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7193), "", "History", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7193) },
                    { 4, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7194), "", "Biology", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7194) },
                    { 5, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7195), "", "Sport", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7195) },
                    { 6, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7196), "", "English", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7196) },
                    { 7, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7197), "", "Khmer", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7197) },
                    { 8, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7198), "", "Utility", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7198) },
                    { 9, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7198), "", "Chemistry", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7198) },
                    { 10, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7199), "", "Earth", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7200) },
                    { 11, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7200), "", "Geolography", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7200) },
                    { 12, new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7201), "", "Chinese", new DateTime(2024, 2, 29, 17, 44, 54, 494, DateTimeKind.Utc).AddTicks(7201) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Subjects",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
