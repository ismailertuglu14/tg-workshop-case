using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 19, 33, 21, 624, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 19, 33, 21, 624, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CategoryTitle", "CoverPath", "CreatedDate", "Price", "StarRate", "Status", "Title" },
                values: new object[] { 3, 2, "Giyim", "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/83c73daf-a685-32fd-8748-d60e02294789/1_org_zoom.jpg", new DateTime(2024, 7, 9, 19, 33, 21, 624, DateTimeKind.Local).AddTicks(6210), 4.500m, 4.0, 1, "Xspedd X-evo Erkek\nYazlık Motosiklet Mont Siyah" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Order", "Path", "ProductId" },
                values: new object[,]
                {
                    { 4, (byte)1, "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/83c73daf-a685-32fd-8748-d60e02294789/1_org_zoom.jpg", 3 },
                    { 5, (byte)2, "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/e3bfef4e-7126-3e1d-8977-8106adbd1879/1_org_zoom.jpg", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 18, 42, 45, 975, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 18, 42, 45, 975, DateTimeKind.Local).AddTicks(2780));
        }
    }
}
