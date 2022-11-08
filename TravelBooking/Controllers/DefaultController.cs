using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
