using System.Collections.Generic;

namespace MovieLand_Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int Runtime { get; set; }
        public string Poster { get; set; }
        public virtual ICollection<MovieCast> Casts { get; set; }
        public virtual ICollection<MovieGenre> Genres { get; set; }
        public virtual ICollection<MovieLanguage> Languages { get; set; }
    }
}
