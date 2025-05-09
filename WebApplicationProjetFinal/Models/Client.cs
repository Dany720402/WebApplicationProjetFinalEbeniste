using System.ComponentModel.DataAnnotations;

namespace WebApplicationProjetFinal.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Nom { get; set; }


        [Required]
        [MaxLength(25)]
        public string? MotdePasse { get; set; }

        [Required]
        [MaxLength(255)]
        
        public string? Email { get; set; }

        [MaxLength(20)]
        public string? Telephone { get; set; }

        [MaxLength(500)]
        public string? Adresse { get; set; }

    }
}
