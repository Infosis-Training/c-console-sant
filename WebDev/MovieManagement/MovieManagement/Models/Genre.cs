using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
