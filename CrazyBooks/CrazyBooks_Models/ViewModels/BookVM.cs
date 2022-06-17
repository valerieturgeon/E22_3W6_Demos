using CrazyBooks_Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.ViewModels
{
    //ViewModel pour Book Upsert
    // Un livre (Book) à la fois
    // plus listes déroulantes via FK pour choisir le sujet (subject) et l'éditeur (publisher)
    public class BookVM
    {
        public Book Book { get; set; }
        public IEnumerable<SelectListItem> SubjectList { get; set; }
        public IEnumerable<SelectListItem> PublisherList { get; set; }
    }
}
