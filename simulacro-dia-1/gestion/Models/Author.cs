using System.ComponentModel.DataAnnotations;

namespace gestion.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Nationality { get; set; }

    }
}
