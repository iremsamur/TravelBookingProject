using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
