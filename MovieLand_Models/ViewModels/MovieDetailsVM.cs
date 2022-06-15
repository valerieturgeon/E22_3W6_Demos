using MovieLand_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieLand_Models.ViewModels
{
    public class MovieDetailsVM
    {
        public MovieDetailsVM()
        {
            Casts = new List<MovieCastForListVM>();
        }
        public MovieDetailsVM(Movie m)
        {
            Id = m.MovieId;
            Poster = m.Poster;
            Title = m.Title;
            Year = m.ReleaseYear.ToString();
            Runtime = (int)Math.Floor(m.Runtime / 60.0) + "h " + (m.Runtime % 60) + "m";
            Genres = string.Join(", ", m.Genres.Select(mg => mg.Genre.Name).OrderBy(n => n));
            Languages = string.Join(", ", m.Languages.Select(ml => ml.Language.Name).OrderBy(n => n));
            OriginalLanguage = m.Languages.Where(ml => ml.IsOriginalLanguage).Select(ml => ml.Language.Name).SingleOrDefault();
            Score = (int)Math.Round(m.VoteAverage * 10);
            VoteCount = m.VoteCount;
            Overview = m.Overview;
            Casts = m.Casts.Where(c => c.Actor.Profile != "").OrderBy(c => c.Order).Take(7).Select(mc => new MovieCastForListVM(mc)).ToList();
        }

        public int Id { get; set; }
        public string Poster { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Runtime { get; set; }
        public string Genres { get; set; }
        public string Languages { get; set; }
        public string OriginalLanguage { get; set; }
        public int Score { get; set; }
        public int VoteCount { get; set; }
        public string Overview { get; set; }
        public List<MovieCastForListVM> Casts { get; set; }
}
}
