using CrazyBooks_Models.Models;
using CrazyBooks_DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrazyBooks_DataAccess.Data;
using CrazyBooks_DataAccess.Repository.IRepository;

namespace CrazyBooks.Controllers
{
  public class SubjectController : Controller
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<SubjectController> _logger;

    public SubjectController(IUnitOfWork unitOfWork, ILogger<SubjectController> logger)
    {
      _unitOfWork = unitOfWork;
      _logger = logger;
    }
    public IActionResult Index()
    {
      IEnumerable<Subject> SubjectList = _unitOfWork.Subject.GetAll();

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
        _unitOfWork.Subject.Add(subject);
     
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
      }
      return this.View(subject);
    }
  }
}
