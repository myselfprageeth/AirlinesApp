using AirlinesApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirlinesApp.Controllers
{
    public class FlightController : Controller
    {
        private readonly AirLineDBContext _dbContext;
        public FlightController(AirLineDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetFlightDetails()
        {
            var result = _dbContext.Airlines.ToList();
            return View(result);
        }
    }
}
