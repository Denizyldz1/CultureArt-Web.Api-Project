using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CultureArt.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateAddressDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Companies_CompanyId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Publishers_PublisherId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "PublisherCompany");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Events_CompanyId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_PublisherId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "AddressDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<string>(
                name: "EventAreaName",
                table: "AddressDetails",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PublisherEvent",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherEvent", x => new { x.PublisherId, x.EventId });
                    table.ForeignKey(
                        name: "FK_PublisherEvent_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublisherEvent_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AddressDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EventAreaName" },
                values: new object[] { new DateTime(2023, 7, 25, 21, 46, 57, 615, DateTimeKind.Local).AddTicks(1183), "Küçük Çiftlik Park" });

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

            migrationBuilder.InsertData(
                table: "PublisherEvent",
                columns: new[] { "EventId", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PublisherEvent_EventId",
                table: "PublisherEvent",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublisherEvent");

            migrationBuilder.DropColumn(
                name: "EventAreaName",
                table: "AddressDetails");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "AddressDetails",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublisherCompany",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherCompany", x => new { x.PublisherId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_PublisherCompany_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublisherCompany_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyAddress", "CreatedDate", "Name" },
                values: new object[] { 1, "Kadırgalar Cad. No:4 ŞİŞLİ / İstanbul", new DateTime(2023, 7, 24, 22, 14, 33, 129, DateTimeKind.Local).AddTicks(7926), "KüçükÇiftlik Park" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "CreatedDate", "PublisherId" },
                values: new object[] { 1, new DateTime(2023, 7, 24, 22, 14, 33, 129, DateTimeKind.Local).AddTicks(9780), 1 });

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

            migrationBuilder.InsertData(
                table: "PublisherCompany",
                columns: new[] { "CompanyId", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CompanyId",
                table: "Events",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PublisherId",
                table: "Events",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_PublisherCompany_CompanyId",
                table: "PublisherCompany",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Companies_CompanyId",
                table: "Events",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Publishers_PublisherId",
                table: "Events",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
