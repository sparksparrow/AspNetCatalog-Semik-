using Microsoft.EntityFrameworkCore.Migrations;

namespace GnomShop.Migrations
{
    public partial class _ArticleGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "ProductItems");

            migrationBuilder.AddColumn<string>(
                name: "Article",
                table: "ProductItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                column: "ConcurrencyStamp",
                value: "fabda90a-c214-4563-b726-f9cf25c1caed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b11a44f-2afd-4c99-ae1b-bc025abbf7d4", "AQAAAAEAACcQAAAAEKPtGYcWUxViOvk/NCiYx+DVioD7gxq3ALWmH7NMkRhfvVvDrJcaxkWj/uc1qSkkug==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Article",
                table: "ProductItems");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "ProductItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                column: "ConcurrencyStamp",
                value: "bce211b8-13ba-423f-b9d7-10b9ba2138c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c86ce6d-bc0d-46af-ab8d-f56e240b4a71", "AQAAAAEAACcQAAAAEEUWyTwKHnnzfV9UTT2bcuUR1TQV2iDXNXq3HPB5tyl9Pm6ZZmw1Tut0tZbuE8KQXA==" });
        }
    }
}
