using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class init342 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "c437833b-33cb-4ef3-bd90-42c8e0c2a5d2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35cb4a57-24fd-4f97-82cf-0f5966a0c1b9", "59ec8dc8-f7c8-46ec-874a-c57ede8e0fd2", "Standard User", "STANDARD USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d00e1f1f-72a5-4d5e-a3e9-c10a5c88858d", "AQAAAAEAACcQAAAAEDukc5GwUcK+yA92zgrHz6fOs2NgrhxQ8myfJyQzoO88gnIvtptqwvfbQWkj42kZ9g==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 13, 7, 26, 42, DateTimeKind.Local).AddTicks(7516));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35cb4a57-24fd-4f97-82cf-0f5966a0c1b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d",
                column: "ConcurrencyStamp",
                value: "d877623d-ac2a-4114-8914-9baa689b2aa5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8945664-4362-4016-9fce-85eb99cffff2", "AQAAAAEAACcQAAAAECRqsBvHjx0pUH6AMncCzfB9SOaOh+vJa18LWhQ7U4CmzxrKV06GyHxMf1Fi/+fjvQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 11, 47, 37, 147, DateTimeKind.Local).AddTicks(8419));
        }
    }
}
