using Microsoft.EntityFrameworkCore.Migrations;

namespace CrazyBooks_DataAccess.Migrations
{
    public partial class AddLiaisonSubjectBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Subject_Id",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_Subject_Id",
                table: "Book",
                column: "Subject_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Subject_Subject_Id",
                table: "Book",
                column: "Subject_Id",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Subject_Subject_Id",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_Subject_Id",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Subject_Id",
                table: "Book");
        }
    }
}
