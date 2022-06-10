using Microsoft.AspNetCore.Mvc;
using MovieManagement.Models;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie1 = new()
            {
                Name = "3 Idiots",
                Code = "A1234",
                Genre = "Comedy",
                Desc = "3 Idiots is a 2009 Indian Hindi-language coming-of-age comedy-drama film written, edited and directed by Rajkumar Hirani.",
                Length = 220,
                imgUrl = "3-idiots.jpeg",
                ReleaseDate = DateOnly.Parse("08/19/2014")
            };

            Movie movie2 = new()
            {
                Name = "KGF 2",
                Code = "A1235",
                Genre = "Action",
                Desc = "The blood-soaked land of Kolar Gold Fields has a new overlord now, Rocky, whose name strikes fear in the heart of his foes. His allies look up to him as their Savior, the government sees him as a threat, and his enemies are clamouring for revenge.",
                Length = 320,
                imgUrl = "kgf-2.jpg",
                ReleaseDate = DateOnly.Parse("01/02/2022")
            };

            Movie movie3 = new()
            {
                Name = "Pushpa: The Rise",
                Code = "A1236",
                Genre = "Action, Drama",
                Desc = "A labourer named Pushpa makes enemies as he rises in the world of red sandalwood smuggling. However, violence erupts when the police attempt to bring down his illegal business.",
                Length = 300,
                imgUrl = "pushpa.jpg",
                ReleaseDate = DateOnly.Parse("08/19/2021")
            };

            List<Movie> movies = new() { movie1, movie2, movie3 };

            return View(movies);
        }
    
        public IActionResult Add()
        {
            return View();
        }
    }
}
