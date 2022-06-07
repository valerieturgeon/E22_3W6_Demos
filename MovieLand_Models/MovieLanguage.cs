using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models
{
    public class MovieLanguage
    {
        [ForeignKey("MovieLanguageMovie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [ForeignKey("MovieLanguageLanguage")]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public bool IsOriginalLanguage { get; set; }
    }
}
