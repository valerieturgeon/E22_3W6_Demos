using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
  public class Subject
  {
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(30, MinimumLength = 5)]
    public string Name { get; set; }

    //Propriété de navigation 1 à plusieurs, côté plusieurs
    public List<Book> Books { get; set; }
  }
}
