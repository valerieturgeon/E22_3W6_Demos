using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Required, MinLength(1), MaxLength(250), Display(Name = "Nom complet")]
        public string Name { get; set; }
        [MinLength(1), MaxLength(250), Display(Name = "Photo")]
        public string Profile { get; set; }
        [InverseProperty("Actor")]
        public virtual ICollection<MovieCast> Movies { get; set; }
    }
}
