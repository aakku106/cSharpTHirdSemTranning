using System.ComponentModel.DataAnnotations;

namespace LibaryManagementSystem.Services
{


    public class Students
    {
        [Required]
        public string? Id { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int? Class { get; set; }
        [Required]
        public string? Address { get; set; }
    }

}