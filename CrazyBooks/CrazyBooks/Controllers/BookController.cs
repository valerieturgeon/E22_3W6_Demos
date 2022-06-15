using CrazyBooks_DataAccess.Data;
using CrazyBooks_Models.Models;
using CrazyBooks_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
           List<Book> BookList = _db.Book.Include(b => b.Subject).ToList();
            
            //List<Book> objList = _db.Book.Include(u => u.Publisher).Include(u => u.Subject)
            //                        .Include(u => u.AuthorsBooks).ThenInclude(u => u.Author).ToList();

            return View(BookList);
        }

        //Upsert = Update (Edit) et Insert (Create) en un
        //GET
        // Paramètre int: Null =Create NotNull Edit
        public IActionResult Upsert(int? id)
        {
            // ViewModel nécessaire pour listes déroulantes (FK)
            BookVM obj = new BookVM();
           
            obj.SubjectList = _db.Subject.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });

            if (id == null)
            {
                //Create
                return View(obj);
            }
            else
            { 
            // Edit
            obj.Book = _db.Book.FirstOrDefault(u => u.Id == id);
            }
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(BookVM obj)
        {
            if (obj.Book.Id == 0)
            {
                //Create
                _db.Book.Add(obj.Book);
            }
            else
            {
                //Edit
                _db.Book.Update(obj.Book);
            }
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
