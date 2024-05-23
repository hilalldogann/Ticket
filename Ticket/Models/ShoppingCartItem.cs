using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class ShoppingCartItem
    {
        [Key]

        public int Id { get; set; } 

        public Activity Activity { get; set; }  

        public int Amount { get; set; } 

        public string ShoppingCartId { get; set; }  


    }
}
