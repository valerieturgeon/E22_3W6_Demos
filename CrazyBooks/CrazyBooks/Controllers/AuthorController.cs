
using CrazyBooks_DataAccess.Data;
using CrazyBooks_Models.Models;
using CrazyBooks_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
    public class AuthorController : Controller
    {
        private readonly CrazyBooksDbContext _db;
        private readonly ILogger<AuthorController> _logger;

        public AuthorController(CrazyBooksDbContext crazyBooksDbContext, ILogger<AuthorController> logger)
        {
            _db = crazyBooksDbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Author> AuthorList = _db.Author.OrderBy(a => a.LastName).ThenBy(a => a.FirstName).ToList();

            return View(AuthorList);
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
                authorVM.Author = _db.Author.Include(a => a.AuthorDetail).FirstOrDefault( a => a.Id == id);

                if (authorVM == null)
                {
                    return NotFound();
                }
                return View(authorVM);
            }

        }

        //POST Upsert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(AuthorVM authorVM)
        {
            if (authorVM.Author.Id == 0)
            {
                //this is create
                _db.Author.Add(authorVM.Author);
            }
            else
            {
                //this is an update
                _db.Author.Update(authorVM.Author);
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

            var obj = _db.Author.Find(id.GetValueOrDefault());
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
            var obj = _db.Author.Find(id.GetValueOrDefault());
            if (obj == null)
            {
                return NotFound();
            }

            _db.Author.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
