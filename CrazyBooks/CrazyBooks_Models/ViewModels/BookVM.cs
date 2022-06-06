using CrazyBooks_Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.ViewModels
{
  public class BookVM
  {
    public Book Book { get; set; }
    public IEnumerable<SelectListItem> PublisherList { get; set; }
    public IEnumerable<SelectListItem> SubjectList { get; set; }
  }
}
