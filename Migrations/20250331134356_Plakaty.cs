using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopUKW2025.Migrations
{
    public partial class Plakaty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "Poster",
                value: "1.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "Poster",
                value: "2.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "Poster",
                value: "3.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "Poster",
                value: "4.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "Poster",
                value: "5.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "Poster",
                value: "6.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7,
                column: "Poster",
                value: "7.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8,
                column: "Poster",
                value: "8.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9,
                column: "Poster",
                value: "9.jfif");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10,
                column: "Poster",
                value: "10.jfif");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Films");
        }
    }
}
