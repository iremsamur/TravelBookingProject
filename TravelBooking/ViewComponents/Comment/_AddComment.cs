using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
