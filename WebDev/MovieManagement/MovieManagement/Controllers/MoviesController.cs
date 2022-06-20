using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Database;
using MovieManagement.Models;
using MovieManagement.ViewModel;

namespace MovieManagement.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public MoviesController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return _context.Movies != null ?
                        View(await _context.Movies.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Movies'  is null.");
        }

        // GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var genres = await _context.Genre.ToListAsync();

            var GenresList = genres.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

            GenresList.Add(new SelectListItem { Text = "Nothing selected...", Value = "", Selected = true });

            MovieViewModel movie = new();

            movie.Geners = GenresList;

            return View(movie);
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Desc,Code,Genre,ReleaseDate,Length,Banner")] MovieViewModel movieViewModel)
        {
            Movie movie = new()
            {
                Name = movieViewModel.Name,
                Desc = movieViewModel.Desc,
                Genre = movieViewModel.Genre,
                Length = movieViewModel.Length,
                ReleaseDate = movieViewModel.ReleaseDate,
            };

            movie.Code = Guid.NewGuid().ToString();

            var stream = new MemoryStream();

            movieViewModel.Banner?.CopyTo(stream);

            movie.Banner = stream.ToArray();

            _context.Movies.Add(movie);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            var genres = await _context.Genre.ToListAsync();

            var GenresList = genres.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

            GenresList.Add(new SelectListItem { Text = "Nothing selected...", Value = "", Selected = true });

            movie.Geners = GenresList;

            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Desc,Code,Genre,ReleaseDate,Length,Banner")] MovieViewModel movieViewModel)
        {
            if (id != movieViewModel.Id)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);

            if (movie != null)
            {
                movie.Name = movieViewModel.Name;
                movie.Genre = movieViewModel.Genre;
                movie.ReleaseDate = movieViewModel.ReleaseDate;
                movie.Length = movieViewModel.Id;
                movie.Desc = movieViewModel.Desc;

                var stream = new MemoryStream();

                movieViewModel.Banner?.CopyTo(stream);

                movie.Banner = stream.ToArray();

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        //POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.Movies == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Movies'  is null.");
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //Copy image to server and return image name to other controller to update in database.
        public string BannerUpload(MovieViewModel input)
        {
            string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "Banners");

            string fileName = Guid.NewGuid().ToString() + "_" + input.Banner.FileName;

            string filePath = Path.Combine(uploadFolder, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                input.Banner.CopyTo(fileStream);
            }

            return fileName;
        }
    }
}
