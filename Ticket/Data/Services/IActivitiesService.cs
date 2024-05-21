using Ticket.Data.Base;
using Ticket.Data.ViewModels;
using Ticket.Models;

namespace Ticket.Data.Services
{
    public interface IActivitiesService : IEntityBaseRepository<Activity>
    {
        Task<Activity> GetActivityByIdAsync(int id);
        Task<NewActivityDropdownsVM> GetNewActivityDropdownsValues();

        Task AddNewActivityAsync(NewActivityVM data);

        Task UpdateActivityAsync(NewActivityVM data);

    }
}
