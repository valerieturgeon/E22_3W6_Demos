using MovieLand_Models.Models;

namespace MovieLand_Models.ViewModels
{
    public class MovieCastForListVM
    {
        public MovieCastForListVM()
        {
        }
        public MovieCastForListVM(MovieCast mc)
        {
            ActorId = mc.ActorId;
            Name = mc.Actor.Name;
            Character = mc.Character;
            Profile = mc.Actor.Profile;
        }
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public string Profile { get; set; }
    }
}
