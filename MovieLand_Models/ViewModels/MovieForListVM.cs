using MovieLand_Models.Models;

namespace MovieLand_Models.ViewModels
{
    public class MovieForListVM
    {
        public MovieForListVM()
        {
        }
        public MovieForListVM(Movie m)
        {
            Id = m.MovieId;
            Title = m.Title;
            Poster = m.Poster;
            Favorite = m.Favorite;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public bool Favorite { get; set; }
    }
}
