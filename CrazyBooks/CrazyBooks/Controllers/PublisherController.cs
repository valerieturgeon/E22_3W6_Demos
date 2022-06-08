using CrazyBooks_DataAccess.Data;
using CrazyBooks_Models.Models;
using CrazyBooks_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class PublisherController : Controller
  {
        private readonly CrazyBooksDbContext _db;

    public PublisherController(CrazyBooksDbContext crazyBooksDbContext)
    {
            _db = crazyBooksDbContext;
    }

    public IActionResult Index()
    {
      List<Publisher> PublisherList =  _db.Publisher.ToList();

      return View(PublisherList);
    }

        public IActionResult Upsert(int? id)
        {
            Publisher obj = new Publisher();
            if (id == null)
            {
                return View(obj);
            }
            //this for edit
            obj = _db.Publisher.FirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Publisher obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Id == 0)
                {
                    //this is create
                    _db.Add(obj);
                }
                else
                {
                    //this is an update
                    _db.Publisher.Update(obj);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(obj);

        }

        public IActionResult Detail(int id)
    {
            PublisherVM PublisherVM = new PublisherVM()
            {
                Publisher = _db.Publisher.FirstOrDefault(p => p.Id == id),
                BooksList = _db.Book.Include(u => u.Publisher)
                                .Include(u => u.AuthorsBooks).ThenInclude(u => u.Author).ToList()


            };
      return View(PublisherVM);
    }

        public IActionResult Delete(int id)
        {
            var objFromDb = _db.Publisher.FirstOrDefault(u => u.Id == id);
            _db.Publisher.Remove(objFromDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
