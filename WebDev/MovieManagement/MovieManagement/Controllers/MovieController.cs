using Microsoft.AspNetCore.Mvc;
using MovieManagement.Database;
using MovieManagement.Models;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var allRows = _context.Movies.ToList();

            return View(allRows);
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
                _context.Movies.Add(new Movie { ImgUrl = "default.JPG" });
                _context.Movies.Add(input);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
