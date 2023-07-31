using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureArt.Data.Migrations
{
    /// <inheritdoc />
    public partial class testPublisherEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublisherEvent_Events_EventId",
                table: "PublisherEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_PublisherEvent_Publishers_PublisherId",
                table: "PublisherEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublisherEvent",
                table: "PublisherEvent");

            migrationBuilder.RenameTable(
                name: "PublisherEvent",
                newName: "PublisherEvents");

            migrationBuilder.RenameIndex(
                name: "IX_PublisherEvent_EventId",
                table: "PublisherEvents",
                newName: "IX_PublisherEvents_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublisherEvents",
                table: "PublisherEvents",
                columns: new[] { "PublisherId", "EventId" });

            migrationBuilder.UpdateData(
                table: "AddressDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 21, 32, 53, 730, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 21, 32, 53, 730, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 21, 32, 53, 730, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 21, 32, 53, 730, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 21, 32, 53, 730, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 21, 32, 53, 730, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 21, 32, 53, 730, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.AddForeignKey(
                name: "FK_PublisherEvents_Events_EventId",
                table: "PublisherEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublisherEvents_Publishers_PublisherId",
                table: "PublisherEvents",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublisherEvents_Events_EventId",
                table: "PublisherEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_PublisherEvents_Publishers_PublisherId",
                table: "PublisherEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublisherEvents",
                table: "PublisherEvents");

            migrationBuilder.RenameTable(
                name: "PublisherEvents",
                newName: "PublisherEvent");

            migrationBuilder.RenameIndex(
                name: "IX_PublisherEvents_EventId",
                table: "PublisherEvent",
                newName: "IX_PublisherEvent_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublisherEvent",
                table: "PublisherEvent",
                columns: new[] { "PublisherId", "EventId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_PublisherEvent_Events_EventId",
                table: "PublisherEvent",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublisherEvent_Publishers_PublisherId",
                table: "PublisherEvent",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
