using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TravelBooking.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        
        //partialview result kullanıyorum.
        //Yorum ekleme
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentState = true;
            int id = comment.DestinationID;
          
            _commentService.TAdd(comment);

            return RedirectToAction("Index", "Destination");
        }

    }
}
