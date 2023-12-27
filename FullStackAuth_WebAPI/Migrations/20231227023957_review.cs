using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "387abfcc-12d2-411b-b799-e8cc95ad731d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aecff5c4-2930-4a2e-89c6-4fb1ca821731");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0eef8e7f-22b9-4736-9814-8aa25de8215c", null, "User", "USER" },
                    { "e0dbb9b1-5874-4b10-a670-8ee8cfb38222", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eef8e7f-22b9-4736-9814-8aa25de8215c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0dbb9b1-5874-4b10-a670-8ee8cfb38222");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "387abfcc-12d2-411b-b799-e8cc95ad731d", null, "User", "USER" },
                    { "aecff5c4-2930-4a2e-89c6-4fb1ca821731", null, "Admin", "ADMIN" }
                });
        }
    }
}
