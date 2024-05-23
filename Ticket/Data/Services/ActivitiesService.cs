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
        public async Task AddNewActivityAsync(NewActivityVM data)
        {
            var newActivity = new Activity()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                ActivityCategory = data.ActivityCategory,
                ProducerId = data.ProducerId
            };
            await _context.Activities.AddAsync(newActivity);
            await _context.SaveChangesAsync();

            //Add  Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorActivity = new Actor_Activity()
                {
                    ActivityId = newActivity.Id,
                    ActorId = actorId
                };
                await _context.Actors_Activities.AddAsync(newActorActivity);
            }
            await _context.SaveChangesAsync();
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

        public async Task<NewActivityDropdownsVM> GetNewActivityDropdownsValues()
        {
            var response = new NewActivityDropdownsVM()
            {
                Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.CinemaName).ToListAsync(),
                Producers= await _context.Producers.OrderBy(n => n.Name).ToListAsync(),

            };
            return response;
        }

        public async Task UpdateActivityAsync(NewActivityVM data)
        {
            var dbActivity = await _context.Activities.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbActivity != null)

            {
                dbActivity.Name = data.Name;
                dbActivity.Description = data.Description;
                dbActivity.Price = data.Price;
                dbActivity.ImageURL = data.ImageURL;
                dbActivity.CinemaId = data.CinemaId;
                dbActivity.StartDate = data.StartDate;
                dbActivity.EndDate = data.EndDate;
                dbActivity.ActivityCategory = data.ActivityCategory;
                dbActivity.ProducerId = data.ProducerId;
                await _context.SaveChangesAsync();
            }
            //remove
            var existingActorsDB = _context.Actors_Activities.Where(n => n.ActivityId == data.Id).ToList();
            _context.Actors_Activities.RemoveRange(existingActorsDB);
            await _context.SaveChangesAsync();
            
            //Add  Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorActivity = new Actor_Activity()
                {
                    ActivityId = data.Id,
                    ActorId = actorId
                };
                await _context.Actors_Activities.AddAsync(newActorActivity);
            }
            await _context.SaveChangesAsync();
        }
    }
}
