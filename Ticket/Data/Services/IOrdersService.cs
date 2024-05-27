using Ticket.Models;

namespace Ticket.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmalAddress);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
