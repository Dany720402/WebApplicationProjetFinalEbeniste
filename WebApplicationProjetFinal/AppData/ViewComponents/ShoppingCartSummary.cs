using Microsoft.AspNetCore.Mvc;
using WebApplicationProjetFinal.AppData.Cart;

namespace WebApplicationProjetFinal.AppData.ViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        //Nous devons invoquer la méthode concernée dans ce viewcomponent
        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            return View(items.Count);
        }
    }

}
