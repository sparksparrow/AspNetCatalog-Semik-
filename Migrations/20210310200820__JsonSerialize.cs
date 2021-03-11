using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GnomShop.Migrations
{
    public partial class _JsonSerialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_DisplayedProducts_DisplayedProductsId",
                table: "ProductItems");

            migrationBuilder.DropIndex(
                name: "IX_ProductItems_DisplayedProductsId",
                table: "ProductItems");

            migrationBuilder.DropColumn(
                name: "DisplayedProductsId",
                table: "ProductItems");

            migrationBuilder.AddColumn<string>(
                name: "Products",
                table: "DisplayedProducts",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Products",
                table: "DisplayedProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "DisplayedProductsId",
                table: "ProductItems",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_DisplayedProductsId",
                table: "ProductItems",
                column: "DisplayedProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_DisplayedProducts_DisplayedProductsId",
                table: "ProductItems",
                column: "DisplayedProductsId",
                principalTable: "DisplayedProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
