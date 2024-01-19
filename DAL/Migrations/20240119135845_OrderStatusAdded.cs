using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class OrderStatusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15cbb5ff-252d-41b7-96d1-0ad9cfafa57c");

            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "e1574e43-53b9-4e84-857b-fb3503c76c47");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30e8d646-90b3-4ea3-acfb-f8ae6f7d01d1", "c2ffaa2c-e550-4158-9bfd-181c03592570", "Standard User", "STANDARD USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c042a2c-fc97-4f86-b62b-f81cba72d258", "AQAAAAEAACcQAAAAEG8AKy3wKLTsxRPU60SXVC+sPwrL4Jcs6WOilKiYYEZoIPJPfhb6p30rwP1tyyN9Pw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 16, 58, 44, 156, DateTimeKind.Local).AddTicks(2663));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30e8d646-90b3-4ea3-acfb-f8ae6f7d01d1");

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "a99180a2-c781-44df-ba52-27a6e12887e9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15cbb5ff-252d-41b7-96d1-0ad9cfafa57c", "c2fc03c8-9112-47a5-b614-81ec6f510732", "Standard User", "STANDARD USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb2a0ef5-c26d-48a8-b304-f647a70aa106", "AQAAAAEAACcQAAAAEE1D6cgeaiwLuZW9jFnaqWMET9Gxvq9K1ncFteCzHGrRCwPxX2RVpzMeP9TALWFVHA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 16, 31, 54, 700, DateTimeKind.Local).AddTicks(5577));
        }
    }
}
