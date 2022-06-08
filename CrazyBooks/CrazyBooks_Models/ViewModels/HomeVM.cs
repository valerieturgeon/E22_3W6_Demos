using CrazyBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.ViewModels
{
  public class HomeVM
  {
    public IEnumerable<Book> Books { get; set; }
    public IEnumerable<Subject> Subjects { get; set; }
  }
}