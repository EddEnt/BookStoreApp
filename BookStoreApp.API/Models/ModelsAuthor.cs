using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models
{
    public class ModelsAuthor
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(1000)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [StringLength(500)]
        public string? Biography { get; set; }
    }
}
