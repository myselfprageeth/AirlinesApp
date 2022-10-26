using AirlinesApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace AirlinesApp.Controllers
{
    public class CustomerCareController : Controller
    {
        private readonly AirLineDBContext _dbContext;
        public CustomerCareController(AirLineDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            var result = _dbContext.CustomerCare.First();
            return View(result);
        }
    }
}
