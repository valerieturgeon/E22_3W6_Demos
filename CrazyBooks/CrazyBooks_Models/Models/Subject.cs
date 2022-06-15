using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
   public class Subject
    {
        //Par convention: Si appelée Id ou NomClasseId EF fait automatiquement de ce champ la clé primaire (no auto)
        [Key]// Indique la clé primaire (non requise ici puisque convention)
        public int Id { get; set; }

        //Annotations avec message erreurs "hardcodés"
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Le Name est obligatoire.")]
        //[StringLength(25, MinimumLength = 5, ErrorMessage = "Le Name doit avoir entre 5 et 25 caractères.")]
        //Annotations avec message erreurs paramétrés
        [Display(Name = "Subject")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le {0} est obligatoire")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Le {0} doit avoir entre {2} et {1}")]
        public string Name { get; set; }
       
        //Propriété de navigation 1 à plusieurs, côté plusieurs
        public List<Book> Books { get; set; }
    }
}
