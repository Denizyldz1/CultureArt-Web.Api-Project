using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureArt.Data.Migrations
{
    /// <inheritdoc />
    public partial class publisherEventUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventUrl",
                table: "EventsFeature");

            migrationBuilder.AddColumn<string>(
                name: "PublisherEventUrl",
                table: "PublisherEvent",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AddressDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 17, 52, 25, 696, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 17, 52, 25, 696, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 17, 52, 25, 696, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 17, 52, 25, 696, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 17, 52, 25, 696, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "PublisherEvent",
                keyColumns: new[] { "EventId", "PublisherId" },
                keyValues: new object[] { 1, 1 },
                column: "PublisherEventUrl",
                value: "https://www.biletix.com/etkinlik/2WW03/TURKIYE/tr");

            migrationBuilder.UpdateData(
                table: "PublisherEvent",
                keyColumns: new[] { "EventId", "PublisherId" },
                keyValues: new object[] { 1, 2 },
                column: "PublisherEventUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 17, 52, 25, 697, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 17, 52, 25, 697, DateTimeKind.Local).AddTicks(81));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherEventUrl",
                table: "PublisherEvent");

            migrationBuilder.AddColumn<string>(
                name: "EventUrl",
                table: "EventsFeature",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AddressDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 21, 46, 57, 615, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 21, 46, 57, 615, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 21, 46, 57, 615, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 21, 46, 57, 615, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 21, 46, 57, 615, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "EventsFeature",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventUrl",
                value: "https://www.biletix.com/etkinlik/2WW03/TURKIYE/tr");

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 21, 46, 57, 615, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 21, 46, 57, 615, DateTimeKind.Local).AddTicks(3777));
        }
    }
}
