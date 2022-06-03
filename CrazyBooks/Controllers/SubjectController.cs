using CrazyBooks.Models;
using CrazyBooks.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class SubjectController : Controller
  {
    private readonly CrazyBooksDbContext _db;
    private readonly ILogger<SubjectController> _logger;

    public SubjectController(CrazyBooksDbContext db, ILogger<SubjectController> logger)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      //Sans Repository Patterns: Redéfini à chaque fois
      List<Subject> objList = _db.Subject.ToList();

      return View(objList);
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
        _db.Add(subject);
        _db.SaveChanges();
      }

      return this.View(subject);
    }
  }
}
