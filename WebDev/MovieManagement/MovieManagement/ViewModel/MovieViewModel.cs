using Microsoft.AspNetCore.Http;
using MovieManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieManagement.ViewModel
{
    public class MovieViewModel : Movie
    {
        [Display(Name="Banner Image")]
        public IFormFile Banner { get; set; }
    }
}
