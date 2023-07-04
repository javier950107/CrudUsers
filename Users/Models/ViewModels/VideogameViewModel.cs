using System.ComponentModel.DataAnnotations;

namespace CRUDUsers.Models.ViewModels
{
    public class VideogameViewModel
    {
        public List<Videogame> Videogames { get; set; }
        public Videogame NewVideogame { get; set; }
    }
}
