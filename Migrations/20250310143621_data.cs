using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopUKW2025.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Filmy pełne akcji, napięcia i spektakularnych scen.", "Action" },
                    { 2, "Filmy mające na celu rozbawienie widza.", "Comedy" },
                    { 3, "Filmy koncentrujące się na emocjonalnych historiach.", "Drama" },
                    { 4, "Filmy wywołujące strach i dreszczyk emocji.", "Horror" },
                    { 5, "Filmy osadzone w przyszłości lub oparte na technologii.", "Science Fiction" },
                    { 6, "Filmy zawierające elementy magiczne lub nadprzyrodzone.", "Fantasy" },
                    { 7, "Filmy skupiające się na relacjach miłosnych.", "Romance" },
                    { 8, "Filmy pełne napięcia i nieoczekiwanych zwrotów akcji.", "Thriller" },
                    { 9, "Filmy animowane, przeznaczone zarówno dla dzieci, jak i dorosłych.", "Animation" },
                    { 10, "Filmy przedstawiające rzeczywiste wydarzenia i tematy.", "Documentary" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Akcja, która nie pozwala na moment odpoczynku.", "John McTiernan", 19.99m, "Die Hard" },
                    { 2, 2, "Komedia o przygodach grupy przyjaciół w Las Vegas.", "Todd Phillips", 14.99m, "The Hangover" },
                    { 3, 3, "Historia o nadziei i przyjaźni wśród więźniów.", "Frank Darabont", 12.99m, "The Shawshank Redemption" },
                    { 4, 4, "Horror oparty na prawdziwych wydarzeniach, które przeraża.", "James Wan", 16.99m, "The Conjuring" },
                    { 5, 5, "Film science-fiction o podróży przez przestrzeń i czas.", "Christopher Nolan", 21.99m, "Interstellar" },
                    { 6, 6, "Pierwsza część przygód młodego czarodzieja.", "Chris Columbus", 18.99m, "Harry Potter and the Sorcerer's Stone" },
                    { 7, 7, "Poruszająca historia miłości przez lata.", "Nick Cassavetes", 13.99m, "The Notebook" },
                    { 8, 8, "Thriller psychologiczny o włamaniu do snów.", "Christopher Nolan", 19.99m, "Inception" },
                    { 9, 9, "Animacja o przygodach zabawek, które ożywają.", "John Lasseter", 9.99m, "Toy Story" },
                    { 10, 10, "Dokument o życiu i pracy Freda Rogersa.", "Morgan Neville", 11.99m, "Won't You Be My Neighbor?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);
        }
    }
}
