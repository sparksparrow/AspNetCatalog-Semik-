using Microsoft.EntityFrameworkCore.Migrations;

namespace GnomShop.Migrations
{
    public partial class _addNewParamToImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MainSliderContents",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MainSliderContents",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alt",
                table: "MainSliderContents",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "MainSliderContents",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "MainSliderContents",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DisplayedProducts",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DisplayedProducts",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "CategoriesOfTheMonths",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CategoriesOfTheMonths",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alt",
                table: "Categories",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "Categories",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alt",
                table: "MainSliderContents");

            migrationBuilder.DropColumn(
                name: "Extension",
                table: "MainSliderContents");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "MainSliderContents");

            migrationBuilder.DropColumn(
                name: "Alt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Extension",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MainSliderContents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MainSliderContents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DisplayedProducts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DisplayedProducts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "CategoriesOfTheMonths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CategoriesOfTheMonths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ba8f64-053a-4574-a0bb-b73ecc88c761",
                column: "ConcurrencyStamp",
                value: "39a654fb-f69d-4728-951b-ec94d39de575");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6e757b-ecb2-40a8-94fe-a2d3ecca28ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26468761-6cd3-4d47-aee8-f900accb5a72", "AQAAAAEAACcQAAAAEG2/7/7pZ2GXCsTi2whbei6cT3Gq2xyuPiHO7lz33wj4n4aelqKvOjvqNRC2NRBgMg==" });
        }
    }
}
