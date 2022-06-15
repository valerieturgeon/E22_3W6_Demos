using MovieLand_Models.Models;

namespace MovieLand_Models.ViewModels
{
    public class GenreForListVM
    {
        public GenreForListVM()
        {
        }
        public GenreForListVM(Genre g)
        {
            Id = g.GenreId;
            Name = g.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
