using Microsoft.AspNetCore.Mvc;
using Ticket.Data.Cart;
using Ticket.Data.Services;
using Ticket.Data.ViewModels;

namespace Ticket.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IActivitiesService _activitiesService;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IActivitiesService activitiesService, ShoppingCart shoppingCart)
        {
            _activitiesService = activitiesService;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
    }
}
