using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class init4352 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Menus_MenuId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Menus",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Menus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "47db4ac2-b551-4ad7-8161-a3ff45fc3cbd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9558c48-be41-48f0-9bf5-0fc92e77b992", "AQAAAAEAACcQAAAAEOy8uIXC2RjUHWkezyxcaEo3Dmzc8cBYb5DlejAS1XxTA8VOSzkBJqpVtDbefjPwGg==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(5171), null, null, "Burger" },
                    { 2, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(5187), null, null, "Beverages" },
                    { 3, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(5188), null, null, "Condiments" },
                    { 4, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(5189), null, null, "Snacks" },
                    { 5, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(5189), null, null, "Desserts" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImagePath", "ModifiedDate", "Name", "OrderId", "Price", "Quantity", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(6071), null, null, "img/burgers/hamburger1kofte.png", null, "Meat Burger", null, 100.0, 1, 0 },
                    { 2, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(6074), null, null, "img/burgers/chickenburger.png", null, "Chicken Burger", null, 85.0, 1, 0 },
                    { 3, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(6075), null, null, "img/beverages/milkshake.jpg", null, "Çilekli Milkshake", null, 30.0, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ImagePath", "MenuId", "ModifiedDate", "Name", "Price", "Quantity" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(5890), null, null, 1, null, "Meat Burger", 100.0, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ImagePath", "MenuId", "ModifiedDate", "Name", "Price", "Quantity" },
                values: new object[] { 2, 1, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(5892), null, null, 2, null, "Chicken Burger", 85.0, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ImagePath", "MenuId", "ModifiedDate", "Name", "Price", "Quantity" },
                values: new object[] { 3, 5, new DateTime(2024, 1, 12, 21, 12, 48, 84, DateTimeKind.Local).AddTicks(5960), null, null, 3, null, "Çilekli Milkshake", 30.0, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Menus_MenuId",
                table: "Products",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Menus_MenuId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Menus");

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Menus",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "a3ab55ac-5763-4481-b233-1ec2e176f6ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31b7d665-16da-4cc9-b255-1b33ccaff52c", "AQAAAAEAACcQAAAAEJTX7WfiIkVoYSBe76/gYClVcenfxkvWvSbapDEXTBq2TWEquFIzDM8TJDx32F7Sgw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Menus_MenuId",
                table: "Products",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
