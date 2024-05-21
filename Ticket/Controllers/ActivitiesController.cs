using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket.Data;
using Ticket.Data.Services;

namespace Ticket.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly IActivitiesService _service;

        public ActivitiesController(IActivitiesService service) 
        { 
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allActivities = await _service.GetAllAsync(n => n.Cinema);
            return View(allActivities);
        }

        public async Task<IActionResult> Details (int id)
        {
            var activityDetail = await _service.GetActivityByIdAsync(id);
            return View(activityDetail);    
        }

        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome our store";
            ViewBag.Description = "This is description";
            return View();
        }

    }
}
