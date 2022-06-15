using System.Collections.Generic;

namespace MovieLand_Models.ViewModels
{
    public class ListOfMoviesVM
    {
        public ListOfMoviesVM()
        {
            Movies = new List<MovieForListVM>();
        }
        public ListOfMoviesVM(List<MovieForListVM> movies, bool showActions = false)
        {
            Movies = movies;
            ShowActions = showActions;
        }

        public bool ShowActions { get; set; }
        public List<MovieForListVM> Movies { get; set; }
    }
}
