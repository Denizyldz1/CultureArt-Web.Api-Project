using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureArt.Data.Migrations
{
    /// <inheritdoc />
    public partial class eventFeatureNameAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventFeature_Events_Id",
                table: "EventFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventFeature",
                table: "EventFeature");

            migrationBuilder.RenameTable(
                name: "EventFeature",
                newName: "EventsFeature");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventsFeature",
                table: "EventsFeature",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AddressDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 16, 26, 31, 111, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.AddForeignKey(
                name: "FK_EventsFeature_Events_Id",
                table: "EventsFeature",
                column: "Id",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventsFeature_Events_Id",
                table: "EventsFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventsFeature",
                table: "EventsFeature");

            migrationBuilder.RenameTable(
                name: "EventsFeature",
                newName: "EventFeature");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventFeature",
                table: "EventFeature",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AddressDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_EventFeature_Events_Id",
                table: "EventFeature",
                column: "Id",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
