using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SelectList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "098488cf-db41-489e-b6e9-1e0cc074b73f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28715e25-a589-471e-9331-406c5274dee1", "AQAAAAEAACcQAAAAEKgFoflx4sEgWr4ceeigozCMV1Zp8sty0FDjc5ymBQtq8XE0Hy5XWngX8UJSxnC7eQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 20, 15, 43, 624, DateTimeKind.Local).AddTicks(3132));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "31ec6efb-f349-48b0-aecf-1fb757a07161");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e284a190-b7e6-49ac-b1ad-439c34078a16", "AQAAAAEAACcQAAAAEC2Teu6Cj3uNtPtJr06rKXYUphqPV8MljSQ2V/fLV9eHlNYGGGQHzsVouDwQIgx38Q==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 14, 19, 48, 42, 100, DateTimeKind.Local).AddTicks(4030));
        }
    }
}
