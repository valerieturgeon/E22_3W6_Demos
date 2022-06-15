using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieLand_DataAccess.Migrations
{
    public partial class Refactor_Movies2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Favorite",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Favorite",
                table: "Movies");
        }
    }
}
