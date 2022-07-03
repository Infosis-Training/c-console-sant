using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Database;
using MovieManagement.Helpers;
using MovieManagement.Mapper;
using MovieManagement.Models;
using MovieManagement.ViewModel;

namespace MovieManagement.Controllers
{
    [Authorize]
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MoviesController(ApplicationDbContext db) // Dependency Injection
        {
            _db = db;
        }

        public IActionResult Index(string sortBy, string search, int pageNumber = 1, int pageSize = 6)
        {
            ViewData["NameSort"]    = sortBy == "name" ? "name_desc" : "name";
            ViewData["GenreSort"]   = sortBy == "genre" ? "genre_desc" : "genre";
            ViewData["LengthSort"]  = sortBy == "length" ? "length_desc" : "length";
            ViewData["DateSort"]    = sortBy == "date" ? "date_desc" : "date";
            ViewData["Search"]      = search;


            var movie = _db.Movies.Include(x => x.Genre).AsQueryable();


            if (!string.IsNullOrEmpty(search))
            {
                movie = movie.Where(m => m.Name.Contains(search) || m.Description.Contains(search));
            }

            movie = sortBy switch
            {
                "name"      => movie = movie.OrderBy(m => m.Name),
                "name_desc" => movie.OrderByDescending(m => m.Name),
                "genre"     => movie = movie.OrderBy(m => m.Genre.Name),
                "genre_desc" => movie = movie.OrderByDescending(m => m.Genre.Name),
                "length"    => movie = movie.OrderBy(m => m.LengthInMin),
                "length_desc" => movie = movie.OrderByDescending(m => m.LengthInMin),
                "date"      => movie.OrderByDescending(m => m.ReleaseDate),
                "date_desc" => movie.OrderBy(m => m.ReleaseDate),
                _ => movie.OrderByDescending(m => m.ReleaseDate)
            };

            var moviesFetched = new PaginationList<Movie>(movie, pageNumber, pageSize);

            var list = moviesFetched.ToPaginatedViewModels();

            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            MovieViewModel movieViewModel = new();

            movieViewModel.Genres = GetGenreSelectListItems();

            return View(movieViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] MovieViewModel movieViewModel)
        {
            var movie = movieViewModel.ToModel();

            try
            {

                if (ModelState.IsValid)
                {
                    _db.Add(movie);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }

            return View(movieViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditAsync(int id)
        {

            var movieToEdit = await _db.Movies.FindAsync(id);

            var movieViewModel = movieToEdit.ToViewModel();

            movieViewModel.Genres = GetGenreSelectListItems();

            return View(movieViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Genre,LengthInMin,ReleaseDate")] MovieViewModel movieViewModel)
        {
            var movieToEdit = await _db.Movies.FindAsync(id);

            movieToEdit.Name = movieViewModel.Name;
            movieToEdit.Description = movieViewModel.Description;
            movieToEdit.GenreId = int.Parse(movieViewModel.Genre);
            movieToEdit.LengthInMin = movieViewModel.LengthInMin;
            movieToEdit.ReleaseDate = movieViewModel.ReleaseDate;

            _db.Movies.Update(movieToEdit);

            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _db.Movies.Remove(movie);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> UploadBanner(int id, [Bind("Banner")] MovieViewModel movieViewModel)
        {
            var movieToEdit = await _db.Movies.FindAsync(id);

            var stream = new MemoryStream();

            movieViewModel.Banner?.CopyTo(stream);

            movieToEdit.Banner = stream.ToArray();

            _db.Movies.Update(movieToEdit);

            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        private List<SelectListItem> GetGenreSelectListItems()
        {
            var genres = _db.Genre.ToList();

            var genresItems = genres.Select(x =>
                            new SelectListItem
                            {
                                Text = x.Name,
                                Value = x.Id.ToString()
                            }).ToList();

            genresItems.Add(new SelectListItem { Text = "Choose gender...", Value = "", Selected = true });

            return genresItems;
        }

    }
}
