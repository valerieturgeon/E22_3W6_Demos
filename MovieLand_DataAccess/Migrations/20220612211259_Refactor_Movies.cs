using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieLand_DataAccess.Migrations
{
    public partial class Refactor_Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "VoteAverage",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "VoteCount",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.5999999999999996, 1194 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.2000000000000002, 15756 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.0, 3580 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.2999999999999998, 1159 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7000000000000002, 8602 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.0999999999999996, 2428 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7000000000000002, 7861 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.2999999999999998, 1265 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.2999999999999998, 3220 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.4000000000000004, 11667 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.2000000000000002, 9826 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 12,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.4000000000000004, 2367 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 13,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.0999999999999996, 4377 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 14,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7999999999999998, 1554 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 15,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7000000000000002, 5817 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 16,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7000000000000002, 3207 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 17,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.2000000000000002, 9033 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 18,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 5.2000000000000002, 6208 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 19,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.2000000000000002, 2711 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 20,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.0999999999999996, 9009 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 21,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 5.0, 3148 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 22,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7000000000000002, 14930 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 23,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.0, 4680 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 24,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 5.9000000000000004, 1221 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 25,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.0, 2586 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 26,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.4000000000000004, 13699 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 27,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.5999999999999996, 13155 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 28,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7999999999999998, 4586 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 29,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.4000000000000004, 5302 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 30,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.2999999999999998, 2395 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 31,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.9000000000000004, 6732 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 32,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.2000000000000002, 9120 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 33,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7999999999999998, 9410 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 34,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.2999999999999998, 4924 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 35,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.0, 5499 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 36,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.0, 1010 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 37,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.4000000000000004, 18638 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 38,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.9000000000000004, 5141 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 39,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7999999999999998, 11747 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 40,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7999999999999998, 13365 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 41,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.2000000000000002, 3283 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 42,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.5, 12643 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 43,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.9000000000000004, 5765 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 44,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.5, 4055 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 45,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.4000000000000004, 8050 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 46,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.5, 1845 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 47,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.5999999999999996, 401 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 48,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.2000000000000002, 1345 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 49,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.2000000000000002, 3340 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 50,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.5999999999999996, 324 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 51,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.2999999999999998, 4419 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 52,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.0999999999999996, 1492 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 53,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.7999999999999998, 1461 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 54,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 6.9000000000000004, 1318 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 55,
                columns: new[] { "VoteAverage", "VoteCount" },
                values: new object[] { 7.0999999999999996, 2398 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoteAverage",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "VoteCount",
                table: "Movies");
        }
    }
}
