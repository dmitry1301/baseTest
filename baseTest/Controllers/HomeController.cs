using baseTest.Data;
using baseTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace baseTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            db = context; // внедряем зависимость контекста БД
        }

        public IActionResult Index()
        {
            var tickets = db.tickets.Include(p => p.User);
            return View(tickets);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("getTickets")]
        public JsonResult GetTicketsResult()
        {
            List<Ticket> tickets = new List<Ticket>();
            var tks = db.tickets;

            foreach (var ticket in tks)
            {
                tickets.Add(new Ticket
                {
                    Id = ticket.Id,
                    CreateDate = ticket.CreateDate,
                    Description = ticket.Description,
                    NameProject = ticket.NameProject,
                    CloseDate = ticket.CloseDate,
                    TicketStatus = ticket.TicketStatus,
                    UserId = ticket.UserId
                });
            }
            return Json(tickets);
        }
    }
}
