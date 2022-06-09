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
                ReleaseDate = DateTime.Parse("2015-01-01")
            };

            Movie movie2 = new()
            {
                Name = "KGF",
                Code = "A1235",
                Genre = "Action",
                Desc = "South Movied",
                Length = 220,
                ReleaseDate = DateTime.Parse("2020-01-01")
            };

            List<Movie> movies = new() { movie1, movie2 };

            return View(movies);
        }
    }
}
