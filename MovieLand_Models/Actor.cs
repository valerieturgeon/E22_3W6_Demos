using System.Collections.Generic;

namespace MovieLand_Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string Profile { get; set; }
        public virtual ICollection<MovieCast> Movies { get; set; }
    }
}
