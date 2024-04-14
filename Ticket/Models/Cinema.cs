using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        //relation
        public List<Activity> Activities { get; set; }
    }
}
