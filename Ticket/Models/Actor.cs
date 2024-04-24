using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Actor
    {

        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name= "Name" )]
        public string Name { get; set; }

        [Display(Name="Biography")]
        public string Biography { get; set; }

        //Relation
        public List<Actor_Activity> Actors_Activities { get; set; }
    }
}
