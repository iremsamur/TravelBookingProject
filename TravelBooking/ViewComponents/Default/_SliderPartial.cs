using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
