using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoGamesContext.Migrations
{
    /// <inheritdoc />
    public partial class CopiesSoldAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopiesSold",
                table: "Games",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopiesSold",
                table: "Games");
        }
    }
}
