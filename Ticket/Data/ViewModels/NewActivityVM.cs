using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ticket.Data.Base;
using Ticket.Data.Enums;

namespace Ticket.Models
{
    public class NewActivityVM 
    {
        public int Id { get; set; }

        [Display(Name=" Activity Name")]
        [Required(ErrorMessage="Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie Poster URL")]
        [Required(ErrorMessage = "Movie poster is required")]
        public string ImageURL { get; set; }

        [Display(Name = "start date")]
        [Required(ErrorMessage = "Start date is required")]

        public DateTime StartDate { get; set; }

        [Display(Name = "end date")]
        [Required(ErrorMessage = "End Date is required")]

        public DateTime EndDate { get; set; }

        [Display(Name = "Select a Category")]
        [Required(ErrorMessage = "Category is required")]
        public ActivityCategory ActivityCategory { get; set; }

        //relation
        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "Actor is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a Cinema")]
        [Required(ErrorMessage = "Cinema is required")]

        public int  CinemaId { get; set; }
        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Producer is required")]
        public int ProducerId { get; set; }
       
    }
}
