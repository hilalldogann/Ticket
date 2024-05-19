using Ticket.Data.Base;
using Ticket.Models;

namespace Ticket.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService

    {
        public CinemasService(AppDbContext context) : base(context) 
        { 

        }
       
    }
}
