using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }

        public string ProfilePictureURL { get; set; }

        public string Name { get; set; }

        public string Biography { get; set; }

        //relation
        public List<Activity> Activities { get; set; }
    }
}
