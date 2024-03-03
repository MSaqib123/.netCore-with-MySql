using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book.Servies.BookAPI.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Author = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishedYear = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBook", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tblBook",
                columns: new[] { "Id", "Author", "ISBN", "PublishedYear", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "978-0743273565", 1925, "The Great Gatsby" },
                    { 2, "Harper Lee", "978-0061120084", 1960, "To Kill a Mockingbird" },
                    { 3, "George Orwell", "978-0451524935", 1949, "1984" },
                    { 4, "Jane Austen", "978-1503290564", 1813, "Pride and Prejudice" },
                    { 5, "J.K. Rowling", "978-0590353427", 1997, "Harry Potter and the Sorcerer's Stone" },
                    { 6, "J.D. Salinger", "978-0316769488", 1951, "The Catcher in the Rye" },
                    { 7, "Harper Lee", "978-0061120084", 1960, "To Kill a Mockingbird" },
                    { 8, "J.R.R. Tolkien", "978-0547928227", 1937, "The Hobbit" },
                    { 9, "J.R.R. Tolkien", "978-0544003415", 1954, "The Lord of the Rings" },
                    { 10, "Herman Melville", "978-1503280787", 1851, "Moby-Dick" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblBook");
        }
    }
}
