using CrazyBooks_Models.Models;
using CrazyBooks_DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrazyBooks_Models.ViewModels;

namespace CrazyBooks.Controllers
{
    public class AuthorController : Controller
    {
        private readonly CrazyBooksDbContext _db;

        public AuthorController(CrazyBooksDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Author> objList = _db.Author.ToList();
            return View(objList);
        }

        //GET - UPSERT
        public IActionResult Upsert(int? id)
        {
            AuthorVM authorVM = new AuthorVM()
            {
                Author = new Author()
            };

            if (id == null)
            {
                //CREATE
                return View(authorVM);
            }
            else
            {
                //EDIT
                authorVM.Author = _db.Author.FirstOrDefault(a => a.Id == id);

                if (authorVM == null)
                {
                    return NotFound();
                }
                return View(authorVM);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Author obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Id == 0)
                {
                    //this is create
                    _db.Author.Add(obj);
                }
                else
                {
                    //this is an update
                    _db.Author.Update(obj);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(obj);

        }

        public IActionResult Delete(int id)
        {
            var objFromDb = _db.Author.FirstOrDefault(u => u.Id == id);
            _db.Author.Remove(objFromDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
