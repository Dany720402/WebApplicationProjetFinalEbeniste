using Microsoft.EntityFrameworkCore;
using WebApplicationProjetFinal.Models;

using WebApplicationProjetFinal.AppData;
using WebApplicationProjetFinal.AppData.ViewData;
using WebApplicationProjetFinal.AppData.Services;

namespace WebApplicationProjetFinal.AppData.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly AppDbContext _context;
        public OrdersService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Meuble).Where(n => n.UserId == userId).ToListAsync();
            return orders;
        }

        public async Task StoreOrderAsync(List<ShoppingCarItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    MeubleID = item.Meuble.MeubleID,
                    OrderId = order.id,
                    Price = (double)item.Meuble.Prix
                };
                await _context.OrdersItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }




    }
}
