using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Ticket.Models;

namespace Ticket.Data.Cart
{
    public class ShoppingCart
    {
        public AppDbContext _context { get; set; }  

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }   

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        public void AddItemToCart(Activity activity)
        {
            var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Activity.Id == activity.Id && n.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {

                    ShoppingCartId = ShoppingCartId,
                    Activity = activity,
                    Amount = 1

                };

                _context.ShoppingCartItems.Add(shoppingCartItem);
            } else
            {
                shoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Activity activity)
        {
            var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Activity.Id == activity.Id && n.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);

                }

                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _context.SaveChanges();

        }



        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems.Where(n=> n.ShoppingCartId==ShoppingCartId).Include(n=> n.Activity).ToList());

        }

        public double GetShoppingCartTotal() => _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).Select(n => n.Activity.Price * n.Amount).Sum();
    }
}
