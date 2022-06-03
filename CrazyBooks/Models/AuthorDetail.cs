using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Models
{
  public class AuthorDetail
  {
    [Key]
    public int Id { get; set; }
    //Type qui permet d'enregistrer la mise en forme en paragraphe et les balise html
    [Column(TypeName = "nvarchar(MAX)")]
    public string Biography { get; set; }

    // Pour le path de l'image
    [MaxLength(60)]
    public string Photo { get; set; }

    //Propriété de navigation 1 à 1
    public Author Author { get; set; }
  }
}
