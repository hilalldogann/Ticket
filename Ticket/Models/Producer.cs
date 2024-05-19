using System.ComponentModel.DataAnnotations;
using Ticket.Data.Base;

namespace Ticket.Models
{
    public class Producer :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "ProfilePictureURL")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name="Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Biography { get; set; }

        //relation
        public List<Activity> Activities { get; set; }
    }
}
