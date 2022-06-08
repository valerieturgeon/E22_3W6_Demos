using CrazyBooks_DataAccess.Data;
using CrazyBooks_Models.Models;
using CrazyBooks_Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CrazyBooks.Controllers
{
  public class HomeController : Controller
  {
        private readonly CrazyBooksDbContext _db;

        public HomeController(CrazyBooksDbContext crazyBooksDbContext)
    {
            _db = crazyBooksDbContext;

        }

    public IActionResult Index()
    {
      HomeVM homeVM = new HomeVM()
      {
        Books = _db.Book.Include(u => u.Publisher)
                               .Include(u => u.AuthorsBooks).ThenInclude(u => u.Author).ToList(),

          Subjects = _db.Subject.ToList()
      };
      return View(homeVM);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

  
  }
}
