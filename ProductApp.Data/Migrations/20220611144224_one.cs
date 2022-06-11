using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Data.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spareparts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparepartCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SparepartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SparepartPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spareparts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpareparts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparepartID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpareparts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSpareparts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSpareparts_Spareparts_SparepartID",
                        column: x => x.SparepartID,
                        principalTable: "Spareparts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ProductCode", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "1", "ürün1", 1000 },
                    { 2, "2", "ürün2", 2000 },
                    { 3, "3", "ürün3", 3000 },
                    { 4, "4", "ürün4", 4000 }
                });

            migrationBuilder.InsertData(
                table: "Spareparts",
                columns: new[] { "Id", "SparepartCode", "SparepartName", "SparepartPrice" },
                values: new object[,]
                {
                    { 1, "1", "yedek parça 1", 100 },
                    { 2, "2", "yedek parça 2", 200 },
                    { 3, "3", "yedek parça 3", 300 },
                    { 4, "4", "yedek parça 4", 400 },
                    { 5, "5", "yedek parça 5", 500 },
                    { 6, "6", "yedek parça 6", 600 },
                    { 7, "7", "yedek parça 7", 700 },
                    { 8, "8", "yedek parça 8", 800 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpareparts_ProductID",
                table: "ProductSpareparts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpareparts_SparepartID",
                table: "ProductSpareparts",
                column: "SparepartID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSpareparts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Spareparts");
        }
    }
}
