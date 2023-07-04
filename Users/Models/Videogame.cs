using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDUsers.Models
{
    public class Videogame
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(255), Display(Name = "Name")]
        public string name { get; set; }

        [Required , StringLength(255), Display(Name = "Description")] 
        public string description { get; set; }
    }
}
