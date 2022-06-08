using CrazyBooks_Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.ViewModels
{
  public class PublisherVM
  {
    public Publisher Publisher { get; set; }
    public IEnumerable<Book> BooksList { get; set; }

  }
}
