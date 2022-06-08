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

    [Display(Name = "NameSubject")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "RequiredValidation")]
    [StringLength(25, MinimumLength = 5, ErrorMessage = "MinMaxCaractersValidation")]
    public string Name { get; set; }

    //Propriété de navigation 1 à plusieurs, côté plusieurs
    public List<Book> Books { get; set; }
  }
}
