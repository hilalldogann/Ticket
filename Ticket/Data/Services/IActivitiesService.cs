using Ticket.Data.Base;
using Ticket.Models;

namespace Ticket.Data.Services
{
    public interface IActivitiesService : IEntityBaseRepository<Activity>
    {
        Task<Activity> GetActivityByIdAsync(int id);
    }
}
