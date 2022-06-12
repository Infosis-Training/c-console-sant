using Microsoft.AspNetCore.Mvc;
using MovieManagement.Models;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        readonly List<Movie> movies = new()
        {
            new Movie
            {
                Name = "3 Idiots",
                Code = "A1234",
                Genre = "Comedy",
                Desc = "3 Idiots is a 2009 Indian Hindi-language coming-of-age comedy-drama film written, edited and directed by Rajkumar Hirani.",
                Length = 220,
                ImgUrl = "3-idiots.jpeg",
                ReleaseDate = DateTime.Parse("08/19/2014")
            },
            new Movie
            {
                Name = "KGF 2",
                Code = "A1235",
                Genre = "Action",
                Desc = "The blood-soaked land of Kolar Gold Fields has a new overlord now, Rocky, whose name strikes fear in the heart of his foes. His allies look up to him as their Savior, the government sees him as a threat, and his enemies are clamouring for revenge.",
                Length = 320,
                ImgUrl = "kgf-2.jpg",
                ReleaseDate = DateTime.Parse("01/02/2022")
            },
            new Movie
            {
                Name = "Pushpa: The Rise",
                Code = "A1236",
                Genre = "Action, Drama",
                Desc = "A labourer named Pushpa makes enemies as he rises in the world of red sandalwood smuggling. However, violence erupts when the police attempt to bring down his illegal business.",
                Length = 300,
                ImgUrl = "pushpa.jpg",
                ReleaseDate = DateTime.Parse("08/19/2021")
            }
        };

        public IActionResult Index()
        {
            return View(movies);
        }

        public IActionResult Add()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Add(Movie input)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            else
            {
                Movie movie = new()
                {
                    Name = input.Name,
                    Code = input.Code,
                    Genre = input.Genre,
                    Desc = input.Desc,
                    Length = input.Length,
                    ImgUrl = "default.JPG",
                    ReleaseDate = input.ReleaseDate
                };

                movies.Add(movie);

                //return RedirectToAction("Index");
                return View("Index", movies);
            }
        }
    }
}
