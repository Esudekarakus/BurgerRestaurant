using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Menus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "1f7fa480-e88b-4019-9f9e-2d89d9d1dec5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fd9568c-984f-455b-aa43-9e1dc27996a9", "AQAAAAEAACcQAAAAEFBxbIm7CGeNnOU1dNH2JjQXsW8uJPGDgYigiv2PEmBtXts32u8I8/bK/GwoeUdQ8Q==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 12, 19, 36, 7, 862, DateTimeKind.Local).AddTicks(7022), null, null, "Burger" },
                    { 2, new DateTime(2024, 1, 12, 19, 36, 7, 862, DateTimeKind.Local).AddTicks(7038), null, null, "Beverages" },
                    { 3, new DateTime(2024, 1, 12, 19, 36, 7, 862, DateTimeKind.Local).AddTicks(7041), null, null, "Condiments" },
                    { 4, new DateTime(2024, 1, 12, 19, 36, 7, 862, DateTimeKind.Local).AddTicks(7044), null, null, "Snacks" },
                    { 5, new DateTime(2024, 1, 12, 19, 36, 7, 862, DateTimeKind.Local).AddTicks(7047), null, null, "Desserts" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "ImagePath", "ModifiedDate", "Name", "OrderId", "Price", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 12, 19, 36, 7, 867, DateTimeKind.Local).AddTicks(7528), null, null, "img/burgers/hamburger1kofte.png", null, "Meat Burger", null, 100.0, 0 },
                    { 2, new DateTime(2024, 1, 12, 19, 36, 7, 867, DateTimeKind.Local).AddTicks(7534), null, null, "img/burgers/chickenburger.png", null, "Chicken Burger", null, 85.0, 0 },
                    { 3, new DateTime(2024, 1, 12, 19, 36, 7, 867, DateTimeKind.Local).AddTicks(7537), null, null, "img/beverages/milkshake.jpg", null, "Çilekli Milkshake", null, 30.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ImagePath", "MenuId", "ModifiedDate", "Name", "Price" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 12, 19, 36, 7, 867, DateTimeKind.Local).AddTicks(6862), null, null, 1, null, "Meat Burger", 100.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ImagePath", "MenuId", "ModifiedDate", "Name", "Price" },
                values: new object[] { 2, 1, new DateTime(2024, 1, 12, 19, 36, 7, 867, DateTimeKind.Local).AddTicks(6873), null, null, 2, null, "Chicken Burger", 85.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ImagePath", "MenuId", "ModifiedDate", "Name", "Price" },
                values: new object[] { 3, 5, new DateTime(2024, 1, 12, 19, 36, 7, 867, DateTimeKind.Local).AddTicks(6876), null, null, 3, null, "Çilekli Milkshake", 30.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus");

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
        }
    }
}
