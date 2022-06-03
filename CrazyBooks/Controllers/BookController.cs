using CrazyBooks.Models;
using CrazyBooks.Models.Data;
using Microsoft.AspNetCore.Mvc;
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

    public BookController(CrazyBooksDbContext db)
    {
      _db = db;
    }

    public IActionResult Index()
    {
       //Sans Repository Patterns: Redéfini à chaque fois
        List<Book> objList = _db.Book.Include(u => u.Publisher)
                                   .Include(u => u.Subject).ToList();
      return View(objList);
    }

    //GET CREATE
    public IActionResult Create()
    {
      return View();
    }

    //POST CREATE
    [HttpPost]
    public IActionResult Create(Book book)
    {
      if (ModelState.IsValid)
      {
        // Ajouter à la BD
        _db.Add(book);
        _db.SaveChanges();
      }

      return this.View(book);
    }
  }
}
