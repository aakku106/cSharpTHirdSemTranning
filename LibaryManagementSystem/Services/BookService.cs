using System.ComponentModel.DataAnnotations;

namespace LibaryManagementSystem.Services
{


    public class Books
    {
        [Required]
        public string? BookId { get; set; }
        [Required]
        public string? BookName { get; set; }
        [Required]
        public string? BookAuthor { get; set; }
        [Required]
        public string? BookReleaseDate { get; set; }
        [Required]
        public int HowManyBooks { get; set; }

    }

}