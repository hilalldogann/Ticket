using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.Models
{
    public class OrderItem
    {
        [Key]

        public int Id { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public int MovieId { get; set; }

        [ForeignKey("CinemaId")]
        public Activity Activity { get; set; }

        public int OrderId { get; set; }

        [ForeignKey("CinemaId")]
        public Order Order { get; set; }

    }
}
