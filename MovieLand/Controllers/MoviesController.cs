using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLand_DataAccess.Data;
using MovieLand_Models.Models;
using MovieLand_Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLand.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieLandDbContext _db;

        public MoviesController(MovieLandDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(
                    new ListOfMoviesVM( 
                            await _db.Movies
                                    .OrderByDescending(m => m.ReleaseYear).ThenBy(m => m.Title)
                                        .Select(m => new MovieForListVM(m))
                                            .ToListAsync(),
                            true
                    )
            );
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieDetailsVM mdvm = await _db.Movies
                                           .Where(m => m.MovieId == id)
                                                .Include(m => m.Casts).ThenInclude(mc => mc.Actor)
                                                .Include(m => m.Genres).ThenInclude(mg => mg.Genre)
                                                .Include(m => m.Languages).ThenInclude(ml => ml.Language)
                                                    .Select(m => new MovieDetailsVM(m))
                                                        .FirstOrDefaultAsync();
            if (mdvm == null)
            {
                return NotFound();
            }

            return View(mdvm);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieId,Title,ReleaseYear,Runtime,Poster")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _db.AddAsync(movie);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(movie);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie m = await _db.Movies.FindAsync(id);
            if (m == null)
            {
                return NotFound();
            }

            return View(m);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieId,Title,ReleaseYear,Runtime,Poster")] Movie movie)
        {
            if (id != movie.MovieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(movie);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(movie);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie m = await _db.Movies.FindAsync(id);
            if (m == null)
            {
                return NotFound();
            }

            return View(m);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Movie m = await _db.Movies.FindAsync(id);
            _db.Remove(m);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<bool> SetFavorite(int? id)
        {
            if (id == null)
            {
                return false;
            }

            Movie m = await _db.Movies.FindAsync(id);
            if (m == null)
            {
                return false;
            }

            m.Favorite = !m.Favorite;

            _db.Update(m);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
