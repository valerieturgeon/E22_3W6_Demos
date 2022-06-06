using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
  public class Book
  {
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string Title { get; set; }
    
    [Required]
    [MaxLength(15)]
    public string ISBN { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    [DisplayFormat(DataFormatString = "{0:c2}")] // Monetaire (currency)
    public double Price { get; set; }

    // Relation 1 à plusieurs, obligatoire
    [ForeignKey("Subject")]
    public int Subject_Id { get; set; }
    //Propriété de navigation 1 à plusieurs, côté 1
    public Subject Subject { get; set; }

    [Display(Name = "PublishedDate")]
    [DataType(DataType.Date)] //Mettre aussi le type de input
    public DateTime PublishedDate { get; set; }

    // Relation 1 à plusieurs, obligatoire
    [ForeignKey("Publisher")]
    public int Publisher_Id { get; set; }
    //Propriété de navigation 1 à plusieurs, côté 1
    public Publisher Publisher { get; set; }

    //Propriété de navigation 1 à plusieurs, côté plusieurs
    public ICollection<AuthorBook> AuthorsBooks { get; set; }
  }
}
