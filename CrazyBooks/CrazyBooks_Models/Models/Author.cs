using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
  public class Author
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    // Relation 1 à 1 facultative
    [ForeignKey("AuthorDetail")]
    public int? AuthorDetail_Id { get; set; }
    //Propriété de navigation 1 à 1
    public AuthorDetail AuthorDetail { get; set; }

    //Propriété de navigation 1 à plusieurs, côté plusieurs
    public ICollection<AuthorBook> AuthorsBooks { get; set; }
  }
}
