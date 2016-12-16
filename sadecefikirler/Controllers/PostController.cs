using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sadecefikirler.Models;
using sadecefikirler.Concrete;
namespace sadecefikirler.Controllers
{
    public class PostController : Controller
    {
        PostConcrete pc = new PostConcrete();
        // GET: Post
        public ActionResult Index()
        {
            var db = new sadecefikirlerEntities();
            
            return View(db.Posts.ToList());
        }
        public ActionResult PostDetails(int id)
        {
            var db = new sadecefikirlerEntities();  // bunu şimdilik yazıyorum repository design patternle yapcaz
            var result = db.Posts.FirstOrDefault(p => p.Id == id);
            return View(result);
        }

        public ActionResult Categories(int id)
        {
            //get categories falan yaparsın bunun için categorie name ye göre arar
            
            return View(pc.GetCategoriePosts(id));
        }
        public ActionResult Blog()
        {
            var db = new sadecefikirlerEntities();
            return View(db.Posts.ToList());
        }

    }
}