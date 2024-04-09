using System.ComponentModel.DataAnnotations;

namespace Hotel9.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
