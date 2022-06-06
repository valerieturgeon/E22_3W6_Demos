using CrazyBooks_DataAccess.Repository.IRepository;
using CrazyBooks_Models.Models;
using CrazyBooks_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class BookController : Controller
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<BookController> _logger;

    public BookController(IUnitOfWork unitOfWork, ILogger<BookController> logger)
    {
      _unitOfWork = unitOfWork;
      _logger = logger;
    }
    public IActionResult Index()
    {
      IEnumerable<Book> objList = _unitOfWork.Book.GetAll(includeProperties:"Publisher,Subject");

      return View(objList);
    }

    //GET CREATE
    public IActionResult Create()
    {
      BookVM bookVM = new BookVM()
      {
        Book = new Book(),
        SubjectList = _unitOfWork.Subject.GetAll().Select(i => new SelectListItem
        {
          Text = i.Name,
          Value = i.Id.ToString()
        }),
        PublisherList = _unitOfWork.Publisher.GetAll().Select(i => new SelectListItem
        {
          Text = i.Name,
          Value = i.Id.ToString()
        })
      };
      return View(bookVM);
    }

    //POST CREATE
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(BookVM bookVM)
    {
      if (ModelState.IsValid)
      {
        // Ajouter à la BD
        _unitOfWork.Book.Add(bookVM.Book);
      }

      _unitOfWork.Save();
      return RedirectToAction(nameof(Index));
    }
  }
}
