using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureArt.Data.Migrations
{
    /// <inheritdoc />
    public partial class lastControl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AddressDetails");

            migrationBuilder.UpdateData(
                table: "AddressDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 22, 14, 33, 129, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 22, 14, 33, 129, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 22, 14, 33, 129, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 22, 14, 33, 129, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 22, 14, 33, 129, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 22, 14, 33, 129, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 22, 14, 33, 130, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 22, 14, 33, 130, DateTimeKind.Local).AddTicks(2127));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Publishers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Events",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AddressDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AddressDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(3941), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(4326), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(4327), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(4327), null });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(4840), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(7002), null });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(9522), null });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(9526), null });
        }
    }
}
