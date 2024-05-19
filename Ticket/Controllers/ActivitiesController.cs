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



    }
}
