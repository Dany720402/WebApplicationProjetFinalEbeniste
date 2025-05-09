using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationProjetFinal.Models
{
    public class Meuble
    {
        [Key]
        public int MeubleID { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Nom { get; set; }

        public string? Description { get; set; }

        [ForeignKey(nameof(Style))]
        public int StyleID { get; set; }

        public Style? Style { get; set; }

        public double? Prix { get; set; }

        [MaxLength(100)]
        public string? TypeDeBois { get; set; }

        public DateTime? DateCreation { get; set; } = DateTime.Now;

        [MaxLength(500)]
        public string? ImageURL { get; set; }




    }
}
