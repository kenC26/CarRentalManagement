using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 14, 9, 47, 642, DateTimeKind.Local).AddTicks(1138), new DateTime(2021, 11, 29, 14, 9, 47, 645, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 14, 9, 47, 645, DateTimeKind.Local).AddTicks(3906), new DateTime(2021, 11, 29, 14, 9, 47, 645, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 29, 14, 9, 47, 648, DateTimeKind.Local).AddTicks(2213), new DateTime(2021, 11, 29, 14, 9, 47, 648, DateTimeKind.Local).AddTicks(2224), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 29, 14, 9, 47, 648, DateTimeKind.Local).AddTicks(2229), new DateTime(2021, 11, 29, 14, 9, 47, 648, DateTimeKind.Local).AddTicks(2231), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 29, 14, 9, 47, 647, DateTimeKind.Local).AddTicks(6664), new DateTime(2021, 11, 29, 14, 9, 47, 647, DateTimeKind.Local).AddTicks(6679), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 29, 14, 9, 47, 647, DateTimeKind.Local).AddTicks(6685), new DateTime(2021, 11, 29, 14, 9, 47, 647, DateTimeKind.Local).AddTicks(6687), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 29, 14, 9, 47, 647, DateTimeKind.Local).AddTicks(6690), new DateTime(2021, 11, 29, 14, 9, 47, 647, DateTimeKind.Local).AddTicks(6691), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 29, 14, 9, 47, 647, DateTimeKind.Local).AddTicks(6694), new DateTime(2021, 11, 29, 14, 9, 47, 647, DateTimeKind.Local).AddTicks(6696), "Rav5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 22, 17, 0, 19, 705, DateTimeKind.Local).AddTicks(8505), new DateTime(2021, 11, 22, 17, 0, 19, 708, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 22, 17, 0, 19, 708, DateTimeKind.Local).AddTicks(4911), new DateTime(2021, 11, 22, 17, 0, 19, 708, DateTimeKind.Local).AddTicks(4921) });
        }
    }
}
