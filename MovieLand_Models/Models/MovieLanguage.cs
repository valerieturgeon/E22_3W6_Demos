using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models.Models
{
    public class MovieLanguage
    {
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [Display(Name = "Langue originale?")]
        public bool IsOriginalLanguage { get; set; }
    }
}
