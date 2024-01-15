using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
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
                value: "a367471e-927f-43fa-9f3d-38b5139892f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b172931f-21d3-47ed-b774-75a416c177b5", "AQAAAAEAACcQAAAAEIIpurstHSGN2VsnsLa/yP5E7Agb61B0GONsbtshbm2ItfjsXoUtw8ahgsG4TYfenQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 34, 27, 419, DateTimeKind.Local).AddTicks(1580));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
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
                value: "a3b16eb9-c0a0-4d50-a959-cfcddaed0273");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aeb60fc2-3b4e-429c-b890-123165f5da82", "AQAAAAEAACcQAAAAEGafYexVW9UEx8h28nJI68GUOP8I3ahDYkVgsOuhOXOw6WoZFcAhdllkMAxwcZVfZw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 636, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 636, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 636, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 636, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 636, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 637, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 637, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 637, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 636, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 636, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 13, 20, 43, 14, 636, DateTimeKind.Local).AddTicks(9758));
        }
    }
}
