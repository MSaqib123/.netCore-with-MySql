using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Servies.BookAPI.Models
{
    [Table("tblBook")]
    public class BookModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int PublishedYear { get; set; }
        [Required]
        public string ISBN { get; set; }
    }

}
