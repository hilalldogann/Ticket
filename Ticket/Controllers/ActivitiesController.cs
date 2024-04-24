﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket.Data;

namespace Ticket.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly AppDbContext _context;

        public ActivitiesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allActivities = await _context.Activities.ToListAsync();
            return View(allActivities);
        }
    }
}