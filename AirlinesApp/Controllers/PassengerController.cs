using AirlinesApp.Data;
using AirlinesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirlinesApp.Controllers
{
    public class PassengerController : Controller
    {
        private readonly AirLineDBContext _airlineDBContext;
        public PassengerController(AirLineDBContext dBContext)
        {
            _airlineDBContext=dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BookTicket()
        {
            return View();
        }

        public IActionResult ViewPassengerBookings()
        {
            var result = _airlineDBContext.BookTicket.ToList();
            return View(result);
        }

        public IActionResult AddTicketBook(BookTicket bookTicket)
        {
            _airlineDBContext.BookTicket.Add(bookTicket);
            _airlineDBContext.SaveChanges();
            return View();
        }
    }
}
