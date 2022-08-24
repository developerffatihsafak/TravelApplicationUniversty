using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelApplication.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentState = true;
            
            commentManager.TAdd(comment);
            return RedirectToAction("Index", "Destination");
        }
    }
}
