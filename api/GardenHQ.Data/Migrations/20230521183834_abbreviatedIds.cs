using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GardenHQ.Data.Migrations
{
    /// <inheritdoc />
    public partial class abbreviatedIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AbbreviatedId",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AbbreviatedId",
                table: "GardenTasks",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbbreviatedId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AbbreviatedId",
                table: "GardenTasks");
        }
    }
}
