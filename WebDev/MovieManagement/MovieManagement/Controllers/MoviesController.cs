using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Database;
using MovieManagement.Mapper;
using MovieManagement.Models;
using MovieManagement.ViewModel;

namespace MovieManagement.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MoviesController(ApplicationDbContext db) // Dependency Injection
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _db.Movies.Include(x => x.Genre).ToListAsync();

            var movieViewModels = movies.Select(x => x.ToViewModel()).ToList();

            return View(movieViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            MovieViewModel movieViewModel = new();

            movieViewModel.Genres = GetGenreSelectListItems();

            return View(movieViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MovieViewModel movieViewModel)
        {
            var movie = movieViewModel.ToModel();

            await _db.Movies.AddAsync(movie);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> EditAsync(int id)
        {

            var movieToEdit = _db.Movies.Find(id);

            var genres = await _db.Genre.ToListAsync();

            var genresItems = genres.Select(x =>
                new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

            genresItems.Add(new SelectListItem { Text = "Choose gender...", Value = "", Selected = true });

            ViewData["GenresItems"] = genresItems;

            return View(movieToEdit);
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
        public async Task<IActionResult> UploadBanner(int id,[Bind("Banner")] MovieViewModel movieViewModel)
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
