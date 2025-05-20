using Microsoft.EntityFrameworkCore;
using ShopUKW2025.Models;

namespace ShopUKW2025.DAL
{
    public class FilmsContext : DbContext
    {

        public DbSet<Film> Films { get; set; }

        public DbSet<Category> Categories { get; set; }

        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Category> categories = new List<Category>
        {
            new Category { CategoryId = 1, Name = "Action", Desc = "Filmy pełne akcji, napięcia i spektakularnych scen." },
            new Category { CategoryId = 2, Name = "Comedy", Desc = "Filmy mające na celu rozbawienie widza." },
            new Category { CategoryId = 3, Name = "Drama", Desc = "Filmy koncentrujące się na emocjonalnych historiach." },
            new Category { CategoryId = 4, Name = "Horror", Desc = "Filmy wywołujące strach i dreszczyk emocji." },
            new Category { CategoryId = 5, Name = "Science Fiction", Desc = "Filmy osadzone w przyszłości lub oparte na technologii." },
            new Category { CategoryId = 6, Name = "Fantasy", Desc = "Filmy zawierające elementy magiczne lub nadprzyrodzone." },
            new Category { CategoryId = 7, Name = "Romance", Desc = "Filmy skupiające się na relacjach miłosnych." },
            new Category { CategoryId = 8, Name = "Thriller", Desc = "Filmy pełne napięcia i nieoczekiwanych zwrotów akcji." },
            new Category { CategoryId = 9, Name = "Animation", Desc = "Filmy animowane, przeznaczone zarówno dla dzieci, jak i dorosłych." },
            new Category { CategoryId = 10, Name = "Documentary", Desc = "Filmy przedstawiające rzeczywiste wydarzenia i tematy." },
            new Category { CategoryId = 11, Name = "Wszystkie", Desc = "Przedstawienie wszystkich filmów graficznie." }
        };

            List<Film> films = new List<Film>
        {
            new Film { FilmId = 1, Title = "Die Hard", Director = "John McTiernan", Desc = "Akcja, która nie pozwala na moment odpoczynku.", Price = 19.99m, CategoryId = 1, Poster = "1.jfif" },
            new Film { FilmId = 2, Title = "The Hangover", Director = "Todd Phillips", Desc = "Komedia o przygodach grupy przyjaciół w Las Vegas.", Price = 14.99m, CategoryId = 2, Poster = "2.jfif" },
            new Film { FilmId = 3, Title = "The Shawshank Redemption", Director = "Frank Darabont", Desc = "Historia o nadziei i przyjaźni wśród więźniów.", Price = 12.99m, CategoryId = 3, Poster = "3.jfif" },
            new Film { FilmId = 4, Title = "The Conjuring", Director = "James Wan", Desc = "Horror oparty na prawdziwych wydarzeniach, które przeraża.", Price = 16.99m, CategoryId = 4, Poster = "4.jfif" },
            new Film { FilmId = 5, Title = "Interstellar", Director = "Christopher Nolan", Desc = "Film science-fiction o podróży przez przestrzeń i czas.", Price = 21.99m, CategoryId = 5, Poster = "5.jfif" },
            new Film { FilmId = 6, Title = "Harry Potter and the Sorcerer's Stone", Director = "Chris Columbus", Desc = "Pierwsza część przygód młodego czarodzieja.", Price = 18.99m, CategoryId = 6, Poster = "6.jfif" },
            new Film { FilmId = 7, Title = "The Notebook", Director = "Nick Cassavetes", Desc = "Poruszająca historia miłości przez lata.", Price = 13.99m, CategoryId = 7, Poster = "7.jfif" },
            new Film { FilmId = 8, Title = "Inception", Director = "Christopher Nolan", Desc = "Thriller psychologiczny o włamaniu do snów.", Price = 19.99m, CategoryId = 8, Poster = "8.jfif" },
            new Film { FilmId = 9, Title = "Toy Story", Director = "John Lasseter", Desc = "Animacja o przygodach zabawek, które ożywają.", Price = 9.99m, CategoryId = 9, Poster = "9.jfif" },
            new Film { FilmId = 10, Title = "Won't You Be My Neighbor?", Director = "Morgan Neville", Desc = "Dokument o życiu i pracy Freda Rogersa.", Price = 11.99m, CategoryId = 10, Poster = "10.jfif" }
        };
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Film>().HasData(films);
        }
        
    }
}
