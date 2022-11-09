using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.ViewComponents.Default
{
    public class _SubAboutPartial : ViewComponent
    {

        private readonly ISubAboutService _subAboutService;

        public _SubAboutPartial(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.TGetList();
            return View(values);
        }
    }
}
