using CrazyBooks_Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.ViewModels
{
  public class AuthorVM
  {
        // Permet de présenter les informations d'une relation un à un
        // Author-AuthorDetail
        // Insert/Update les deux en même temps, même formulaire
        public Author Author { get; set; }
        //public Author AuthorDetail { get; set; }
        // Author detail
        
        public string Biography { get; set; }
        // Pour le path de l'image
        [MaxLength(60)]
        public string Photo { get; set; }



    }
}
