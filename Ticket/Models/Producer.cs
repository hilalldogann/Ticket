using System.ComponentModel.DataAnnotations;
using Ticket.Data.Base;

namespace Ticket.Models
{
    public class Producer :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "ProfilePictureURL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name="Biography")]
        public string Biography { get; set; }

        //relation
        public List<Activity> Activities { get; set; }
    }
}
