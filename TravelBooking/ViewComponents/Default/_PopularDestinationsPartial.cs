using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.ViewComponents.Default
{
    public class _PopularDestinationsPartial : ViewComponent
    {
        //DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly IDestinationService _destinationService; //UI tarafında readonly ile private tanımlanır

        //dependency injection

        public _PopularDestinationsPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
    }
}
