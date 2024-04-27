using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Ticket.Data;
using Ticket.Data.Services;
using Ticket.Models;

namespace Ticket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        // actors/create
        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("name", "ProfilePictureURL", "Biography")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));

        }
    }
}
