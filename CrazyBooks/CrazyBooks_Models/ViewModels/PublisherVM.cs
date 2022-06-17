using CrazyBooks_Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.ViewModels
{
    //View présentant un éditeur (publisher) à la fois
    // avec la liste des livres (book) publiés par cet éditeur
    // Master-Details pattern
  public class PublisherVM
  {
    public Publisher Publisher { get; set; }
    public IEnumerable<Book> BooksList { get; set; }

  }
}
