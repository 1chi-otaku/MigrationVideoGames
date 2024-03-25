using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoGamesContext.Migrations
{
    /// <inheritdoc />
    public partial class IsSingleAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSingle",
                table: "Games",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSingle",
                table: "Games");
        }
    }
}
