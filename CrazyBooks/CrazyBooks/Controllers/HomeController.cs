using CrazyBooks_Models;
using CrazyBooks_DataAccess.Data;
using CrazyBooks_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CrazyBooksDbContext _db;

        public HomeController(ILogger<HomeController> logger, CrazyBooksDbContext crazyBooksDbContext)
        {
            _logger = logger;
            _db = crazyBooksDbContext;
        }

        // Action présentant une View des livres disponibles pouvant être filtrés par sujet (Subject)
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()

            {
                // Afficher seulement les Books disponibles (available)
                // triés par date de publication (PublishedDate) du plus récent au plus ancient (décroissant)
                Books = _db.Book.Where(b => b.Available == true).OrderByDescending(b => b.PublishedDate).Include(u => u.Publisher).Include(u => u.Subject).ToList(),
                Subjects = _db.Subject.OrderBy(s => s.Name).ToList()
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
