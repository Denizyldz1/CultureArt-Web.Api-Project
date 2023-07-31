using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureArt.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateEntityEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "EventFeature");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "EventFeature");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "Deneme");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "EventFeature",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "EventFeature",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
