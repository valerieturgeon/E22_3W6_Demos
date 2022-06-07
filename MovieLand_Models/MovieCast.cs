using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models
{
    public class MovieCast
    {
        [ForeignKey("MovieCastMovie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [ForeignKey("MovieCastActor")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
    }
}