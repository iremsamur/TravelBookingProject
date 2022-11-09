using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelBooking.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //istatistiksel veriler
            using var c = new Context();
            ViewBag.destinationCount = c.Destinations.Count();
            ViewBag.tourGuides = c.Guides.Count();
            ViewBag.customerCount = 285;
            return View();
        }

    }
}
