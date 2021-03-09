using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GnomShop.Migrations
{
    public partial class _NewIndexMainTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisplayed",
                table: "ProductItems");

            migrationBuilder.DropColumn(
                name: "IsNovelty",
                table: "ProductItems");

            migrationBuilder.AddColumn<Guid>(
                name: "DisplayedProductsId",
                table: "ProductItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoriesOfTheMonths",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesOfTheMonths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisplayedProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayedProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainSliderContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSliderContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductItemType = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CategoriesOfTheMonthId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_CategoriesOfTheMonths_CategoriesOfTheMonthId",
                        column: x => x.CategoriesOfTheMonthId,
                        principalTable: "CategoriesOfTheMonths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "CategoriesOfTheMonths",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { new Guid("c47769a0-9fa9-49ed-b498-5ccc2fb0fad2"), "Популярно на данный момент.", "Категории месяца" });

            migrationBuilder.InsertData(
                table: "DisplayedProducts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { new Guid("75870a12-4373-430b-ba0a-896f12ededa5"), "Здесь мы выбираем самые оригинальные модели", "Лучшие продукты" });

            migrationBuilder.InsertData(
                table: "MainSliderContents",
                columns: new[] { "Id", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("533effa6-5734-4a7b-a0df-bfe7cd1f70ec"), "Покупаем и продаем по справедливым ценам.", null, "Все по честному" },
                    { new Guid("22526841-1fbd-4cf0-a47d-3633b34b8203"), "Мы находим и придумываем самые оригинальные модели.", null, "Красиво - не значит дрого" },
                    { new Guid("2db8e5d3-f584-4cc3-b7ff-29a8f2c1e5fd"), "Наши контакты вы можете найти на сайте", null, "Всегда на связи" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoriesOfTheMonthId", "Image", "ProductItemType" },
                values: new object[] { new Guid("ad7dc04e-c931-4cb3-ae77-ee424e1bdfa4"), new Guid("c47769a0-9fa9-49ed-b498-5ccc2fb0fad2"), null, 0 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoriesOfTheMonthId", "Image", "ProductItemType" },
                values: new object[] { new Guid("a6289bfa-f30e-436b-b8e7-3037d2324a95"), new Guid("c47769a0-9fa9-49ed-b498-5ccc2fb0fad2"), null, 0 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoriesOfTheMonthId", "Image", "ProductItemType" },
                values: new object[] { new Guid("ff210f50-7193-4f8e-8189-0521fdad28d2"), new Guid("c47769a0-9fa9-49ed-b498-5ccc2fb0fad2"), null, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_DisplayedProductsId",
                table: "ProductItems",
                column: "DisplayedProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoriesOfTheMonthId",
                table: "Categories",
                column: "CategoriesOfTheMonthId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_DisplayedProducts_DisplayedProductsId",
                table: "ProductItems",
                column: "DisplayedProductsId",
                principalTable: "DisplayedProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_DisplayedProducts_DisplayedProductsId",
                table: "ProductItems");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "DisplayedProducts");

            migrationBuilder.DropTable(
                name: "MainSliderContents");

            migrationBuilder.DropTable(
                name: "CategoriesOfTheMonths");

            migrationBuilder.DropIndex(
                name: "IX_ProductItems_DisplayedProductsId",
                table: "ProductItems");

            migrationBuilder.DropColumn(
                name: "DisplayedProductsId",
                table: "ProductItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsDisplayed",
                table: "ProductItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNovelty",
                table: "ProductItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
    }
}
