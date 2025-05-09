using System.ComponentModel.DataAnnotations;

namespace WebApplicationProjetFinal.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Nom { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Prenom { get; set; }

        [Required]
        [MaxLength(255)]
        
        public string? Email { get; set; }

        [MaxLength(500)]
        public string? Message { get; set; }

    }
}
