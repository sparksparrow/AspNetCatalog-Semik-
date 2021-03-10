using Microsoft.EntityFrameworkCore.Migrations;

namespace GnomShop.Migrations
{
    public partial class _switchToPluralTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                column: "ConcurrencyStamp",
                value: "9d2b8090-5573-403c-ac98-4588dbb4d09f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e22b78c-937c-4d2c-9e98-353413398006", "AQAAAAEAACcQAAAAEC6fJFrNopIENVJmShc3qmawBub+X0l7eV8Lb2LkfkMJrDRpjE8Ll4JHT5oL22Tuwg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                column: "ConcurrencyStamp",
                value: "66773391-e883-4409-9b28-27e23cab6a01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "631335de-02c7-4a34-890d-6664e792569b", "AQAAAAEAACcQAAAAEO9KkUkjk+WPGne0CgMhybkUN0oebtZpTgmxCTpC8KkJl04doBxSeHH4U85P6mQXDg==" });
        }
    }
}
