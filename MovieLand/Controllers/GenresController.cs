using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLand_DataAccess.Data;
using MovieLand_Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLand.Controllers
{
    public class GenresController : Controller
    {
        private readonly MovieLandDbContext _db;

        public GenresController(MovieLandDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _db.Genres
                                .OrderBy(g => g.Name)
                                    .Select(g => new GenreForListVM(g))
                                        .ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GenreDetailsVM gdvm = new GenreDetailsVM(await _db.Genres.Include(g => g.Movies).ThenInclude(mg => mg.Movie).ToListAsync(), (int)id);
            if (gdvm == null)
            {
                return NotFound();
            }

            return View(gdvm);
        }

        public async Task<IActionResult> GetMovies(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListOfMoviesVM lmvm = new ListOfMoviesVM(
                await _db.Genres
                        .Include(g => g.Movies).ThenInclude(mg => mg.Movie)
                        .Where(g => g.GenreId == id)
                            .SelectMany(g => g.Movies)
                                .OrderByDescending(mg => mg.Movie.ReleaseYear).ThenBy(mg => mg.Movie.Title)
                                .Select(mg => new MovieForListVM(mg.Movie))
                                .ToListAsync()
            );

            return PartialView("_ListOfMovies", lmvm);
        }
    }
}
