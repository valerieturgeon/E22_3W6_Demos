using CrazyBooks_Models.Models;
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
        public Author Author { get; set; }
       

        // Author detail
                public string Biography { get; set; }
        // Pour le path de la photo
        [MaxLength(60)]
        public string Photo { get; set; }
    }
}
