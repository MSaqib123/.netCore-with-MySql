using Book.Servies.BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Book.Servies.BookAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BookModel> BooksModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookModel>().HasData(
            new BookModel
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                PublishedYear = 1925,
                ISBN = "978-0743273565"
            },
            new BookModel
            {
                Id = 2,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                PublishedYear = 1960,
                ISBN = "978-0061120084"
            },
            new BookModel
            {
                Id = 3,
                Title = "1984",
                Author = "George Orwell",
                PublishedYear = 1949,
                ISBN = "978-0451524935"
            },
            new BookModel
            {
                Id = 4,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                PublishedYear = 1813,
                ISBN = "978-1503290564"
            },
            new BookModel
            {
                Id = 5,
                Title = "Harry Potter and the Sorcerer's Stone",
                Author = "J.K. Rowling",
                PublishedYear = 1997,
                ISBN = "978-0590353427"
            },
            new BookModel
            {
                Id = 6,
                Title = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                PublishedYear = 1951,
                ISBN = "978-0316769488"
            },
            new BookModel
            {
                Id = 7,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                PublishedYear = 1960,
                ISBN = "978-0061120084"
            },
            new BookModel
            {
                Id = 8,
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                PublishedYear = 1937,
                ISBN = "978-0547928227"
            },
            new BookModel
            {
                Id = 9,
                Title = "The Lord of the Rings",
                Author = "J.R.R. Tolkien",
                PublishedYear = 1954,
                ISBN = "978-0544003415"
            },
            new BookModel
            {
                Id = 10,
                Title = "Moby-Dick",
                Author = "Herman Melville",
                PublishedYear = 1851,
                ISBN = "978-1503280787"
            }
        );
        }
    }
}
