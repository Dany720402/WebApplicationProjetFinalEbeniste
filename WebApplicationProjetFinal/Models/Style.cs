using System.ComponentModel.DataAnnotations;

namespace WebApplicationProjetFinal.Models
{
    public class Style
    {
        [Key]
        public int StyleID { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nom { get; set; }

        public List<Meuble>? Meubles { get; set; }



    }
}
