using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Data.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpareparts",
                table: "ProductSpareparts");

            migrationBuilder.DropIndex(
                name: "IX_ProductSpareparts_SparepartID",
                table: "ProductSpareparts");

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductSpareparts");

            migrationBuilder.AlterColumn<string>(
                name: "SparepartName",
                table: "Spareparts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SparepartCode",
                table: "Spareparts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpareparts",
                table: "ProductSpareparts",
                columns: new[] { "SparepartID", "ProductID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpareparts",
                table: "ProductSpareparts");

            migrationBuilder.AlterColumn<string>(
                name: "SparepartName",
                table: "Spareparts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SparepartCode",
                table: "Spareparts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductSpareparts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpareparts",
                table: "ProductSpareparts",
                column: "Id");

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
                name: "IX_ProductSpareparts_SparepartID",
                table: "ProductSpareparts",
                column: "SparepartID");
        }
    }
}
