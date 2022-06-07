using System.Collections.Generic;

namespace MovieLand_Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieLanguage> Movies { get; set; }
    }
}
