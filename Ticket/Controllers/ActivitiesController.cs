using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ticket.Data;
using Ticket.Data.Services;
using Ticket.Models;

namespace Ticket.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly IActivitiesService _service;

        public ActivitiesController(IActivitiesService service) 
        { 
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allActivities = await _service.GetAllAsync(n => n.Cinema);

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allActivities.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allActivities);
        }



        [AllowAnonymous]
        public async Task<IActionResult> Details (int id)
        {
            var activityDetail = await _service.GetActivityByIdAsync(id);
            return View(activityDetail);    
        }

        public async Task <IActionResult> Create()
        {
            var activitiesDropdownsData = await _service.GetNewActivityDropdownsValues();
            ViewBag.Cinemas = new SelectList(activitiesDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(activitiesDropdownsData.Producers, "Id", "Name");
            ViewBag.Actors = new SelectList(activitiesDropdownsData.Actors, "Id", "Name");
            
            return View();
        }

       

        [HttpPost]
        public async Task<IActionResult> Create(NewActivityVM activity)
        {
            if (!ModelState.IsValid)
            {
                var activityDropdownsData = await _service.GetNewActivityDropdownsValues();

                ViewBag.Cinemas = new SelectList(activityDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(activityDropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(activityDropdownsData.Actors, "Id", "FullName");

                return View(activity);
            }

            await _service.AddNewActivityAsync(activity);
            return RedirectToAction(nameof(Index));
        }




        //details

        public async Task<IActionResult> Edit(int id)
        {
            var activityDetails = await _service.GetActivityByIdAsync(id);
            if(activityDetails == null) return View("NotFound");

            var response = new NewActivityVM()
            {
                Id = activityDetails.Id,
                Name = activityDetails.Name,
                Description = activityDetails.Description,
                Price = activityDetails.Price,
                StartDate = activityDetails.StartDate,
                EndDate = activityDetails.EndDate,
                ImageURL = activityDetails.ImageURL,
                ActivityCategory = activityDetails.ActivityCategory,
                CinemaId = activityDetails.CinemaId,
                ProducerId = activityDetails.ProducerId,
                ActorIds = activityDetails.Actors_Activities.Select(n => n.ActorId).ToList(),
            };



            var activitiesDropdownsData = await _service.GetNewActivityDropdownsValues();
            ViewBag.Cinemas = new SelectList(activitiesDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(activitiesDropdownsData.Producers, "Id", "Name");
            ViewBag.Actors = new SelectList(activitiesDropdownsData.Actors, "Id", "Name");

            return View(response);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(int id,NewActivityVM activity)
        {

            if (id != activity.Id) return View("NotFound");



            if (!ModelState.IsValid)
            {
                var activityDropdownsData = await _service.GetNewActivityDropdownsValues();

                ViewBag.Cinemas = new SelectList(activityDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(activityDropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(activityDropdownsData.Actors, "Id", "FullName");

                return View(activity);
            }

            await _service.UpdateActivityAsync(activity);
            return RedirectToAction(nameof(Index));
        }

    }
}
