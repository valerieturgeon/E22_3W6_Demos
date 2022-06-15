using MovieLand_Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieLand_Models.ViewModels
{
    public class GenreDetailsVM
    {
        public GenreDetailsVM()
        {
        }
        public GenreDetailsVM(ICollection<Genre> genres, int genreId)
        {
            string selectedName = genres.Where(g => g.GenreId == genreId).Select(g => g.Name).FirstOrDefault();
            Genres = genres.OrderBy(g => g.Name.CompareTo(selectedName) >= 0 ? 0 : 1).ThenBy(g => g.Name).Select(g => new GenreForListVM(g)).ToList();
            MovieList = new ListOfMoviesVM(
                                genres
                                    .Where(g => g.GenreId == genreId)
                                        .FirstOrDefault()
                                            .Movies
                                                .OrderByDescending(mg => mg.Movie.ReleaseYear).ThenBy(mg => mg.Movie.Title)
                                                    .Select(mg => new MovieForListVM(mg.Movie))
                                                        .ToList()
                            );
        }
        public List<GenreForListVM> Genres { get; set; }
        public ListOfMoviesVM MovieList { get; set; }
}
}
