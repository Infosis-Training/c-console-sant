using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Database;
using MovieManagement.Models;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        //create a property for DB initializaiton
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        //initialize db context
        public MovieController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        //Index Page
        public IActionResult Index()
        {

            //We can also pass other data to view directly using view data or view bag

            //ViewBag.Test = new List<String> { "Sant", "Bohara" };
            ViewBag.Title = "Movie";

            //Get list of all movies
            var allRows = _context.Movies.ToList();

            //Return to view with all list
            return View(allRows);
        }

        //Add Page
        public async Task<IActionResult> Add()
        {
            var genres = await _context.Genre.ToListAsync();

            var GenresList  = genres.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

            GenresList.Add(new SelectListItem { Text = "Nothing selected...", Value = "", Selected = true });

            ViewData["generesList"] = GenresList;
            return View();
        }

        //Save add details
        [HttpPost]
        public IActionResult Add(Movie input)
        {
            //Do form validation
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            //Save if form is validated
            else
            {

                input.Code = Guid.NewGuid().ToString();

                _context.Movies.Add(input);
                _context.SaveChanges();

                //redirecte to Index page once task is completed
                return RedirectToAction(nameof(Index));
            }
        }

        //Edit Page
        //Note for self: Add & Edit Controller can be merged checking ID null case....
        public IActionResult Edit(int id)
        {
            //Get details for selected id
            var movie = _context.Movies.Find(id);

            //Return to view with data
            return View(movie);
        }

        //Save Edit details, also delete the data
        //Save controller is used since the both button redirect to same POST form's action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie input, string submit)
        {

            //if Submit type is Update
            if (submit == "Update")
            {
                //Do form validation
                if (!ModelState.IsValid)
                {
                    return View();
                }
                else
                {
                    //Stage data if everything is ok 
                    _context.Movies.Update(input);
                }
            }

            //if submit type is Delete
            else if (submit == "Delete")
            {
                _context.Movies.Remove(input);
                _context.SaveChanges();
            }

            //Save Changes
            _context.SaveChanges();

            //Redirect to Index once task is completed.
            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BannerUpload([FromForm]Movie input)
        {
            var movie = _context.Movies.Find(input.Id);

            string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "Banners");

            string fileName = Guid.NewGuid().ToString() + "_" + input.ImgUrl.FileName;

            string filePath = Path.Combine(uploadFolder, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                input.ImgUrl.CopyTo(fileStream);
            }

             //movie.ImgUrl = fileName;

            _context.Movies.Update(movie);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
