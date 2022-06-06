using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
  public class AuthorBook
  { // Relation 1 à plusieurs, obligatoire
    [ForeignKey("Book")]
    public int Book_Id { get; set; }

    // Relation 1 à plusieurs, obligatoire
    [ForeignKey("Author")]
    public int Author_Id { get; set; }

    //Propriété de navigation 1 à plusieurs, côté 1
    public Book Book { get; set; }
    //Propriété de navigation 1 à plusieurs, côté 1
    public Author Author { get; set; }
  }
}
