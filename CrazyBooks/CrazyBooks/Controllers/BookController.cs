using CrazyBooks_DataAccess.Data;
using CrazyBooks_Models.Models;
using CrazyBooks_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CrazyBooks.Controllers
{
  public class BookController : Controller
  {
        private readonly CrazyBooksDbContext _db;

        public BookController(CrazyBooksDbContext crazyBooksDbContext)
    {
            _db = crazyBooksDbContext;
        }
    public IActionResult Index()
    {
            //List<Book> objList = _db.Book.ToList();
            List<Book> objList = _db.Book.Include(u => u.Publisher).Include(u => u.Subject)
                                    .Include(u => u.AuthorsBooks).ThenInclude(u => u.Author).ToList();

            return View(objList);
    }

        public IActionResult Upsert(int? id)
        {
            BookVM obj = new BookVM();
            obj.PublisherList = _db.Publisher.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
             obj.SubjectList = _db.Publisher.Select(i => new SelectListItem
             {
                 Text = i.Name,
                 Value = i.Id.ToString()
             });
            if (id == null)
            {
                return View(obj);
            }
            //this for edit
            obj.Book = _db.Book.FirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(BookVM obj)
        {
            if (obj.Book.Id == 0)
            {
                //this is create
                _db.Book.Add(obj.Book);
            }
            else
            {
                //this is an update
                _db.Book.Update(obj.Book);
            }
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

  //GET DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Book.FirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST DELETE
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Book.FirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Book.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
