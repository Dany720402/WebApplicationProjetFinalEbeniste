using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationProjetFinal.Models
{
    public class OrderItem
    {


        public int Id { get; set; }
        public int Amount { get; set; }

        public double Price { get; set; }

        public int MeubleID { get; set; }
        [ForeignKey("MeubleID")]
        public Meuble? Meuble { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]


        public Order? Order { get; set; }
    }
}
