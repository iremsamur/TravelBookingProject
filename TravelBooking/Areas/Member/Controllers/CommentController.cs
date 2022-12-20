using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.Areas.Member.Controllers
{
    [Area("Member")] //Areanın adı member yazılır.
    [AllowAnonymous]//giriş yapmadan da sayfaya ulaşabilelim
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
