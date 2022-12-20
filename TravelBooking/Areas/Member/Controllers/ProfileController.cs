using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
