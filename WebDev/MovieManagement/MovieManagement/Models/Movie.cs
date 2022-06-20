using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagement.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3,ErrorMessage ="Name must be atleast 3 Char.")]
        public string Name { get; set; } = "";

        [Required]
        [DisplayName("Movie Brief Details")]
        public string Desc { get; set; } = "";

        public string? Code { get; set; } = "";

        [Required]
        [DisplayName("Choose Genre")]
        public string Genre { get; set; } = "";

        [NotMapped]
        public List<SelectListItem> Geners { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DisplayName("Movie Length (in Minute)")]
        public int Length { get; set; }

        public byte[] Banner { get; set; }
    }
}
