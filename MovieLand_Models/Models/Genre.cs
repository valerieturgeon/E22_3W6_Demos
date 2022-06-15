using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Required, MinLength(1), MaxLength(250), Display(Name = "Nom")]
        public string Name { get; set; }
        [InverseProperty("Genre")]
        public virtual ICollection<MovieGenre> Movies { get; set; }
    }
}
