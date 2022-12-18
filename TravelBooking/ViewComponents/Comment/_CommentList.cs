using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }
        //destination id değerine göre yorum getirme
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetDestinationByID(id);
            return View(values);
        }

    }
}
