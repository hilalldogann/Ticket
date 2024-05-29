using System.ComponentModel.DataAnnotations;
using Ticket.Data.Base;

namespace Ticket.Models
{
    public class Actor : IEntityBase
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]

        [Required (ErrorMessage ="Profile Picture Required")]
        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Name must be between 3 and 50 chars!")]
        [Display(Name= "FullName" )]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Biography is Required")]
        [Display(Name="Biography")]
        public string Biography { get; set; }

        //Relation
        public List<Actor_Activity>? Actors_Activities { get; set; }
    }
}
