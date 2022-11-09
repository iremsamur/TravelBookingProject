using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _FeaturePartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            //var values = _featureService.TGetList();
           // ViewBag.image1 = _featureService.
           //buraya en son bak yap
            return View();

        }
    }
}
