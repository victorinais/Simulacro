using System.ComponentModel.DataAnnotations;

namespace gestion.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Pages { get; set; }
        [Required]
        public string? Language { get; set; }
        [Required]
        public DateOnly PublicationDate { get; set; }
        [Required]
        public string? Description { get; set; }

    }
}