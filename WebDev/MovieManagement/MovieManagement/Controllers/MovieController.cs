using Microsoft.AspNetCore.Mvc;
using MovieManagement.Database;
using MovieManagement.Models;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        //create a property for DB initializaiton
        private readonly ApplicationDbContext _context;

        //initialize db context
        public MovieController(ApplicationDbContext context)
        {
            _context = context;
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
        public IActionResult Add()
        {
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
                input.ImgUrl = "default.JPG";

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
        public IActionResult Edit(Movie input, string submit)
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
    }
}
