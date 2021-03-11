using Microsoft.EntityFrameworkCore.Migrations;

namespace GnomShop.Migrations
{
    public partial class _JsonField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                column: "ConcurrencyStamp",
                value: "e9625127-4287-4a96-882b-55ec7b6e578b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94b31855-b1fd-41c6-b996-ce4d83a4d250", "AQAAAAEAACcQAAAAEOeej2VzYcd94UDQgAQz0BV0QqJDnk5T4x+okdsrKfqwjyG5FhAUnvnEvkkJEN20YA==" });
        }
    }
}
