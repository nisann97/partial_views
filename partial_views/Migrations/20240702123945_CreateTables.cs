using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace partial_views.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instagrams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instagrams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SliderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurpriseImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurpriseImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurpriseText",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurpriseText", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Date", "Description", "Image", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 2, 16, 39, 44, 999, DateTimeKind.Local).AddTicks(1210), "Blog1", "blog-feature-img-1.jpg", false, "Flower Power" },
                    { 2, new DateTime(2024, 7, 2, 16, 39, 44, 999, DateTimeKind.Local).AddTicks(1230), "Blog2", "blog-feature-img-3.jpg", false, "Local Florists" },
                    { 3, new DateTime(2024, 7, 2, 16, 39, 44, 999, DateTimeKind.Local).AddTicks(1230), "Blog3", "blog-feature-img-4.jpg", false, "Flower Beauty" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, "POPULAR", false },
                    { 2, "WINTER", false },
                    { 3, "VARIOUS", false },
                    { 4, "EXOTIC", false },
                    { 5, "GREENS", false },
                    { 6, "CACTUSES", false }
                });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "Image", "Name", "Profession", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, "h3-team-img-1.png", "CRYSTAL BROOKS", "Florist", false },
                    { 2, "h3-team-img-2.png", "SHIRLEY HARRIS", "Manager", false },
                    { 3, "h3-team-img-3.png", "BEVERLY CLARK", "Florist", false },
                    { 4, "h3-team-img-4.png", "AMANDA WATKINS", "Florist", false }
                });

            migrationBuilder.InsertData(
                table: "SliderInfos",
                columns: new[] { "Id", "Description", "Signature", "SoftDeleted", "Title" },
                values: new object[] { 1, "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.", "h2-sign-img.png", false, "<h1>Send<span>flowers</span>like</h1><h1>you mean it </h1>" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, "h3-slider-background.jpg", false },
                    { 2, "h3-slider-background-2.jpg", false },
                    { 3, "h3-slider-background-3.jpg", false }
                });

            migrationBuilder.InsertData(
                table: "SurpriseImages",
                columns: new[] { "Id", "Name", "SoftDeleted" },
                values: new object[] { 1, "h3-video-img.jpg", false });

            migrationBuilder.InsertData(
                table: "SurpriseText",
                columns: new[] { "Id", "Description", "SoftDeleted", "Title" },
                values: new object[] { 1, "Where flowers are our inspiration to create lasting memories. Whatever the occasion...", false, "<h1>Suprise Your<span>Valentine!</span> Let us arrange a smile.</h1>" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, 1, "Desc1", "Product1", 259m, false },
                    { 2, 2, "desc2", "Product2", 259m, false },
                    { 3, 3, "desc3", "Product3", 259m, false },
                    { 4, 4, "desc4", "Product4", 259m, false },
                    { 5, 5, "desc5", "Product5", 259m, false },
                    { 6, 6, "desc6", "Product6", 259m, false },
                    { 7, 3, "desc7", "Product7", 259m, false },
                    { 8, 2, "desc8", "Product8", 259m, false }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "IsMain", "Name", "ProductId", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, false, "shop-14-img.jpg", 1, false },
                    { 2, false, "shop-13-img.jpg", 2, false },
                    { 3, false, "shop-12-img.jpg", 3, false },
                    { 4, false, "shop-11-img.jpg", 4, false },
                    { 5, false, "shop-10-img.jpg", 5, false },
                    { 6, false, "shop-9-img.jpg", 6, false },
                    { 7, false, "shop-8-img.jpg", 7, false },
                    { 8, false, "shop-7-img.jpg", 8, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Instagrams");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "SliderInfos");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "SurpriseImages");

            migrationBuilder.DropTable(
                name: "SurpriseText");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
