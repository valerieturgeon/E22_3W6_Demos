using CrazyBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class SubjectController : Controller
  {
    public IActionResult Index()
    {
      this.ViewBag.MaListe = new List<Subject>()
      {
        new Subject(){Name= "Thriller", Id=1},
        new Subject(){Name= "Biographie", Id=2},
        new Subject(){Name= "Drame", Id=3},
        new Subject(){Name= "Ressources humaines", Id=4}
      };
      return View();
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
      }

      return this.View(subject);
    }
  }
}
