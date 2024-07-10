using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CategoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DisplayTitle", "IsActive", "Path" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 9, 17, 32, 18, 357, DateTimeKind.Local).AddTicks(5310), "Elektronik", true, "elektronik" },
                    { 2, new DateTime(2024, 7, 9, 17, 32, 18, 357, DateTimeKind.Local).AddTicks(5340), "Giyim", true, "giyim" },
                    { 3, new DateTime(2024, 7, 9, 17, 32, 18, 357, DateTimeKind.Local).AddTicks(5340), "Ev Eşyaları", true, "ev-esyalari" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
