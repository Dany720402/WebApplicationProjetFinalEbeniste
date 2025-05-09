using System.ComponentModel.DataAnnotations;

namespace WebApplicationProjetFinal.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        public string? Email { get; set; }
        public string? UserId { get; set; }

        public List<OrderItem> OrderItems { get; set; }


    }
}
