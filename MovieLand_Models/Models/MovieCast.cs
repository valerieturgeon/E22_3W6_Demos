using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models.Models
{
    public class MovieCast
    {
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        [Required, MinLength(1), MaxLength(250), Display(Name = "Personnage")]
        public string Character { get; set; }
        [Required, Range(1, 300), Display(Name = "Ordre d'affichage")]
        public int Order { get; set; }
    }
}