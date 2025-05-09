using System.ComponentModel.DataAnnotations;

namespace WebApplicationProjetFinal.Models
{
    public class ShoppingCarItem
    {
        [Key]
        public int Id { get; set; }

        public Meuble Meuble { get; set; }

        public int Amount { get; set; }


        //Id unique du panier pour chaque utilisateur qui sera utilisé pour relier les articles au bon panier

        public string? ShoppingCartId { get; set; }



    }
}
