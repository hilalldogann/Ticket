using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
       public string Name { get; set; }
        [Display(Name = "De scription")]
        public string Description { get; set; }

        //relation
        public List<Activity> Activities { get; set; }
    }
}
