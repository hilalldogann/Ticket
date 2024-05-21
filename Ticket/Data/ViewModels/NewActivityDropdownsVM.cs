using Ticket.Controllers;
using Ticket.Models;

namespace Ticket.Data.ViewModels
{
    public class NewActivityDropdownsVM
    {
        public NewActivityDropdownsVM() 
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors= new List<Actor>();

        }

        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }

        public List<Actor> Actors { get; set; }
    }
}
