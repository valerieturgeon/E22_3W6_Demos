using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand_Models.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        [Required, MinLength(2), MaxLength(2)]
        public string Code { get; set; }
        [Required, MinLength(1), MaxLength(250), Display(Name = "Nom")]
        public string Name { get; set; }
        [InverseProperty("Language")]
        public virtual ICollection<MovieLanguage> Movies { get; set; }
    }
}
