using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Actor
    {

        [Key]
        public int ActorId { get; set; }

        public string ProfilePictureURL { get; set; }

        public string Name { get; set; }

        public string Biography { get; set; }

        //Relation
        public List<Actor_Activity> Actors_Activities { get; set; }
    }
}
