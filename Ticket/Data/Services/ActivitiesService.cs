using Ticket.Data.Base;
using Ticket.Models;

namespace Ticket.Data.Services
{
    public class ActivitiesService : EntityBaseRepository<Activity>, IActivitiesService
    {
        public ActivitiesService( AppDbContext context) : base(context)
        {
                
        }

        public Task<Activity> GetActivityByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
