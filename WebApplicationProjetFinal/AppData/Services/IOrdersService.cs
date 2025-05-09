using WebApplicationProjetFinal.Models;

namespace WebApplicationProjetFinal.AppData.Services
{
    public interface IOrdersService
    {

        Task StoreOrderAsync(List<ShoppingCarItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId);


    }
}
