using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Data.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ProductSpareparts",
                columns: new[] { "ProductID", "SparepartID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 7 },
                    { 4, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductSpareparts",
                keyColumns: new[] { "ProductID", "SparepartID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpareparts",
                keyColumns: new[] { "ProductID", "SparepartID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpareparts",
                keyColumns: new[] { "ProductID", "SparepartID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpareparts",
                keyColumns: new[] { "ProductID", "SparepartID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpareparts",
                keyColumns: new[] { "ProductID", "SparepartID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpareparts",
                keyColumns: new[] { "ProductID", "SparepartID" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpareparts",
                keyColumns: new[] { "ProductID", "SparepartID" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpareparts",
                keyColumns: new[] { "ProductID", "SparepartID" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
