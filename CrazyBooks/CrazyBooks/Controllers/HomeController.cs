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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;

namespace CrazyBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CrazyBooksDbContext _db;
        //TODO 07: Injection des resources localizer locals / shared
        private readonly IStringLocalizer<HomeController> _localizer;


        public HomeController(ILogger<HomeController> logger, CrazyBooksDbContext crazyBooksDbContext, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _db = crazyBooksDbContext;
            _localizer = localizer;
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

        //TODO 06: Insérez ici l'action SetLanguage (le cookie)
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            var cookie = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture));
            var name = CookieRequestCultureProvider.DefaultCookieName;

            Response.Cookies.Append(name, cookie, new CookieOptions
            {
                Path = "/",
                Expires = DateTimeOffset.UtcNow.AddYears(1),
            });

            return LocalRedirect(returnUrl);
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
