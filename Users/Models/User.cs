using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDUsers.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required, StringLength(255), Display(Name = "Email")]
        public string email { get; set; }
        [Required, StringLength(255), Display(Name = "Name")]
        public string name { get; set; }

        [StringLength(255), Display(Name = "Password")]
        public string password { get; set; }
    }
}
