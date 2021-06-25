using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Products_ProductId1",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId1",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_ProductId1",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_WarehouseId1",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "WarehouseId1",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "WarehouseIdId",
                table: "Storages");

            migrationBuilder.AlterColumn<int>(
                name: "StorageId",
                table: "Warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Storages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "Storages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ProductId",
                table: "Storages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_WarehouseId",
                table: "Storages",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Products_ProductId",
                table: "Storages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId",
                table: "Storages",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Products_ProductId",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_ProductId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_WarehouseId",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Storages");

            migrationBuilder.AlterColumn<string>(
                name: "StorageId",
                table: "Warehouses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Storages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Storages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId1",
                table: "Storages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarehouseIdId",
                table: "Storages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ProductId1",
                table: "Storages",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_WarehouseId1",
                table: "Storages",
                column: "WarehouseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Products_ProductId1",
                table: "Storages",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId1",
                table: "Storages",
                column: "WarehouseId1",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
