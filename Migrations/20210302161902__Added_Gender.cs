using Microsoft.EntityFrameworkCore.Migrations;

namespace GnomShop.Migrations
{
    public partial class _Added_Gender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "ProductItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                column: "ConcurrencyStamp",
                value: "81cca60e-e02e-4e0e-97fd-d9fb77796fe2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a21fe07-480f-494b-905e-a62e5aad176f", "AQAAAAEAACcQAAAAEDbn5NgYKorERZci2O3iDI7hL5sDosNqvzZOKxmmOIA0ucJg7mLzGInEj6T4yjB+aA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "ProductItems",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                column: "ConcurrencyStamp",
                value: "ea0517aa-2b3f-4089-92f3-af3d9835682f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22e0ea25-ce72-485f-ad24-d8afd7692ccd", "AQAAAAEAACcQAAAAEKeeCSiFtWGGHDDbcN9yzY/vg5HMN4H5gQDTFkAtwa1/KCPcUaWrG5CAf65YoLLjbw==" });
        }
    }
}
