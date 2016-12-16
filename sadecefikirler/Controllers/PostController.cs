using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sadecefikirler.Models;
namespace sadecefikirler.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            var db = new sadecefikirlerEntities();
            
            return View(db.Posts.ToList());
        }
    }
}