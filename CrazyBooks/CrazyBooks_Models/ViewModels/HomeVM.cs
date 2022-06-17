using CrazyBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.ViewModels
{
    // View présentant les livres (bbok) disponibles
    // pouvant ¸etre filtrés par sujet (subject)
    // Filtres patterns
  public class HomeVM
  {
    public IEnumerable<Book> Books { get; set; }
    public IEnumerable<Subject> Subjects { get; set; }
  }
}