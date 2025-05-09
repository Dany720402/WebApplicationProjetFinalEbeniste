using WebApplicationProjetFinal.Models;

using Microsoft.EntityFrameworkCore;

namespace WebApplicationProjetFinal.AppData.Cart
{
    public class ShoppingCart
    {

        public AppDbContext _context { get; set; }
        //ID pour relier les articles au bon panier dans la BD
        public string? ShoppingCartId { get; set; }

        //Liste des articles actuellement dans le panier
        public List<ShoppingCarItem> ShoppingCarItems { get; set; }

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        //Configurations de la session du shoppingCart
        //Cette méthode statique permet de retrouver ou créer
        //un panier d'achat unique stockée en session
        //pour un utilisateur à partir du contexte HTTP 
        public static ShoppingCart GetShoppingCart(IServiceProvider services) //Récupérer une instance du panier d'achat
        {
            //Récupération de la session avec injection dépendance pour obtenir un accès au contexte HTTP courant
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            //Récupération du contexte de la base de données pour lire/ecrire les items du panier dans la base
            var context = services.GetService<AppDbContext>();

            //Lecture ou création d'un ID de panier à partir de la session,
            //si cet ID n'existe pas encore on crée un nouvel identifiant unique
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            //Sauvegarde de l'ID dans la session  
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }






        //Méthode pour récupérer tous les éléments du panier
        public List<ShoppingCarItem> GetShoppingCartItems()
        {
            //Vérifie si la liste des articles est chargée,si c'est null la partie à droite est exécuté
            return ShoppingCarItems ?? (ShoppingCarItems = _context.ShoppingCarItems.Where(n => n.ShoppingCartId == ShoppingCartId).Include(n => n.Meuble).ToList());
        }

        //Méthode pour avoir le total des articles
        public double GetShoppingCartTotal()
        {
            var total = _context.ShoppingCarItems.Where(n => n.ShoppingCartId == ShoppingCartId)
                                                  .Select(n => n.Meuble.Prix * n.Amount).Sum();
            return (double) total;
        }


        //Ajout des articles dans le panier
        public void AddItemToCart(Meuble meuble)
        {
            //Recherche d'un meuble existant dans le panier     
            var shoppingCartItem = _context.ShoppingCarItems.FirstOrDefault(n => n.Meuble.MeubleID == meuble.MeubleID && n.ShoppingCartId == ShoppingCartId);
            //si le livre n'existe pas encore dans le panier créer un nouvel article
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCarItem()
                {
                    ShoppingCartId = ShoppingCartId,  //Associe l'article au panier actuel
                    Meuble = meuble,  //Associe le meuble passé en paramètre à l'article
                    Amount = 1     //initialise la quantité à 1 puisque l'article vient d'être ajouté

                };
                _context.ShoppingCarItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;  //si l'article existe déjà dans le panier augmenter la quantité de 1
            }
            _context.SaveChanges();
        }


        //Retirer un article du panier
        public void RemoveItemFromCart(Meuble meuble)
        {
            //Recherche d'un livre existant dans le panier
            var shoppingCartItem = _context.ShoppingCarItems.FirstOrDefault(n => n.Meuble.MeubleID == meuble.MeubleID && n.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                }
                else
                {
                    _context.ShoppingCarItems.Remove(shoppingCartItem);
                }

            }
            _context.SaveChanges();
        }

        public async Task ClearShoppingCartAsync()
        {
            var items = await _context.ShoppingCarItems.Where(n => n.ShoppingCartId == ShoppingCartId).ToListAsync();
            _context.ShoppingCarItems.RemoveRange(items);
            await _context.SaveChangesAsync();
        }




    }
}
