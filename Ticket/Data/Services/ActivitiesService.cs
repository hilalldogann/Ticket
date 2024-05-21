using Microsoft.EntityFrameworkCore;
using Ticket.Data.Base;
using Ticket.Data.ViewModels;
using Ticket.Models;

namespace Ticket.Data.Services
{
    public class ActivitiesService : EntityBaseRepository<Activity>, IActivitiesService
    {
        private readonly AppDbContext _context;
        public ActivitiesService( AppDbContext context) : base(context)
        { 
            _context = context;
                
        }

        public async Task<Activity> GetActivityByIdAsync(int id)
        {
            var activityDetails = await _context.Activities
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am =>am.Actors_Activities).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n =>n.Id == id);
            return activityDetails;
        }

        public Task<NewActivityDropdownsVM> GetNewActivityDropdownsValues()
        {
            throw new NotImplementedException();
        }
    }
}
