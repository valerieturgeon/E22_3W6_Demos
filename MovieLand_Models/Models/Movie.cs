using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required,MinLength(1),MaxLength(250),Display(Name ="Titre")]
        public string Title { get; set; }
        [Required, Range(1990,2199), Display(Name = "Année de sortie")]
        public int ReleaseYear { get; set; }
        [Required, Range(1, 500), Display(Name = "Durée en minutes")]
        public int Runtime { get; set; }
        [Required, MinLength(1), MaxLength(250), Display(Name = "Affiche")]
        public string Poster { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public bool Favorite { get; set; }
        public string Overview { get; set; }

        [InverseProperty("Movie")]
        public virtual ICollection<MovieCast> Casts { get; set; }
        [InverseProperty("Movie")]
        public virtual ICollection<MovieGenre> Genres { get; set; }
        [InverseProperty("Movie")]
        public virtual ICollection<MovieLanguage> Languages { get; set; }
    }
}
