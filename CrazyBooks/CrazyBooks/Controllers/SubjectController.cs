using CrazyBooks_Models.Models;
using CrazyBooks_DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrazyBooks_DataAccess.Data;

namespace CrazyBooks.Controllers
{
  // Utilisation des méthodes asynchrones
  public class SubjectController : Controller
  {
    private readonly CrazyBooksDbContext _db;

    public SubjectController(CrazyBooksDbContext crazyBooksDbContext)
    {
            _db = crazyBooksDbContext;
     
    }
    public IActionResult Index()
    {
      List<Subject> SubjectList = _db.Subject.ToList();

      return View(SubjectList);
    }

    //GET CREATE
    public IActionResult Create()
    {
     return View();
    }

    //POST CREATE
    [HttpPost]
    public IActionResult Create(Subject subject)
    {
      if (ModelState.IsValid)
      {
        // Ajouter à la BD
      _db.Subject.Add(subject);

      _db.SaveChanges();
       return RedirectToAction(nameof(Index));
      }
      return this.View(subject);
    }

        //GET EDIT
        public IActionResult Edit(int id)
        {
            Subject sbj = new Subject();

            sbj = _db.Subject.FirstOrDefault(u => u.Id == id);
            if (sbj == null)
            {
                return NotFound();
            }
            return View(sbj);
        }

        //POST EDIT
        [HttpPost]
        public IActionResult Edit(Subject subject)
        {
            if (ModelState.IsValid)
            {
                // Ajouter à la BD
                _db.Subject.Update(subject);

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return this.View(subject);
        }

        public IActionResult Delete(int id)
        {
            var objFromDb = _db.Subject.FirstOrDefault(u => u.Id == id);
            _db.Subject.Remove(objFromDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
