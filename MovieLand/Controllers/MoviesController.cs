using Microsoft.AspNetCore.Mvc;
using MovieLand_DataAccess.Data;
using MovieLand_Models;
using System;
using System.Collections.Generic;
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

        public IActionResult Index()
        {
            return View(_db.Movies.OrderByDescending(m => m.ReleaseYear).ThenBy(m => m.Title).ToList());
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var movie = _db.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MovieId,Title,ReleaseYear,Runtime,Poster")] Movie movie)
        {
            if(ModelState.IsValid)
            {
                _db.Add(movie);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(movie);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("MovieId,Title,ReleaseYear,Runtime,Poster")] Movie movie)
        {
            if(id != movie.MovieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(movie);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(movie);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var movie = _db.Movies.Find(id);
            _db.Remove(movie);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
