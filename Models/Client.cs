using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Hotel9.Models
{
    public class Client : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public long Id_card { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public bool Regular_client { get; set; }
    }
}
