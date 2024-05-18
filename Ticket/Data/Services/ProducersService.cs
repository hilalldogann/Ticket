using Ticket.Data.Base;
using Ticket.Models;

namespace Ticket.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
                
        }
    }
}
