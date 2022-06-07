using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models
{
    public class MovieGenre
    {
        [ForeignKey("MovieGenreMovie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [ForeignKey("MovieGenreGenre")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
