using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieManagement.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagement.ViewModel
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name must be of at least 3 chars")]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        [Required]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        [Required]
        public float LengthInMin { get; set; }

        public IFormFile Banner { get; set; }
        public string BannerDataUrl { get; set; }

        [Required]
        public string Genre { get; set; } = string.Empty;
        public List<SelectListItem> Genres { get; set; }
    }
}
