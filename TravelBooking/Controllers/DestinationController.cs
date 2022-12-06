using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
        //Rota detayları için
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = _destinationService.TGetDestinationDetails(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();

        }
    }
}
