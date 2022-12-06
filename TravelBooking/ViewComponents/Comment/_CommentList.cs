using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
