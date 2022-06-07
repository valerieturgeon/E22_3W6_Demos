using System.Collections.Generic;

namespace MovieLand_Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieGenre> Movies { get; set; }
    }
}
