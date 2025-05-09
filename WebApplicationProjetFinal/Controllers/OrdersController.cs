using Microsoft.AspNetCore.Mvc;
using WebApplicationProjetFinal.AppData.Services;
using WebApplicationProjetFinal.AppData.Cart;
using WebApplicationProjetFinal.AppData.ViewData;

namespace WebApplicationProjetFinal.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMeubleService _meubleService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrdersService _ordersService;
        public OrdersController(IMeubleService meubleService, ShoppingCart shoppingCart, IOrdersService ordersService)
        {
            _meubleService = meubleService;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
        }





        public IActionResult ShoppingCart()
        {

            //recupération de la liste des articles du panier
            var items = _shoppingCart.GetShoppingCartItems();
            //On assigne cette liste à la propriété qui sera utilisée pour l'affichage
            _shoppingCart.ShoppingCarItems = items;

            //On prépare une instance du modèle de vue,pour l'affichage
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,    // l'objet panier avec les articles
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()  //le total
            };



            return View(response);
        }

        // Méthode pour ajouter un article dans le panier  
        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _meubleService.GetByIdAsync(id);
            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));

        }

        //Méthode pour retirer un article dans le panier
        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _meubleService.GetByIdAsync(id);
            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));

        }


        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            string userId = "";
            string userEmailAddress = "";

            await _ordersService.StoreOrderAsync(items, userId, userEmailAddress);

            await _shoppingCart.ClearShoppingCartAsync();

            return View("OrderCompleted");
        }




    }
}
