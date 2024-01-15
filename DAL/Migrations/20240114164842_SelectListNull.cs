using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SelectListNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
