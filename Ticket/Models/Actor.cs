using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Actor
    {

        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Picture")]

        [Required (ErrorMessage ="Profile Picture Required")]
        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Name must be between 3 and 50 chars!")]
        [Display(Name= "Name" )]
        public string Name { get; set; }
        [Required(ErrorMessage = "Biography is Required")]
        [Display(Name="Biography")]
        public string Biography { get; set; }

        //Relation
        public List<Actor_Activity> Actors_Activities { get; set; }
    }
}
