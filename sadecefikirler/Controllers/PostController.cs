using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            var result = db.Posts.Where(p => p.Id == id).Take(1).ToList();
            return View(result);
        }

        public ActionResult NewsBlogDetails(int id)
        {
            var db = new sadecefikirlerEntities();
            var result = db.Posts.Where(p => p.Id == id).Take(1).ToList();
            return View(result);
        }

        public ActionResult Categories(int id)
        {
            //get categories falan yaparsın bunun için categorie name ye göre arar
            
            return View(pc.GetCategoriePosts(id));
        }

        public ActionResult NewsBlog()
        {
            var db = new sadecefikirlerEntities();
            return View(db.Posts.ToList());
        }

        public ActionResult Blog()
        {
            var db = new sadecefikirlerEntities();
            return View(db.Posts.ToList());
        }

        public ActionResult Share()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Share(FormCollection collection, HttpPostedFileBase image)
        {
            if (collection["title"]!=null)
            {
                var uploadBase = "";
                if (image != null)
                {
                    var filePath = Path.GetFileName(image.FileName);
                    uploadBase = Path.Combine(Server.MapPath("~/Images"), filePath);
                    image.SaveAs(uploadBase);
                }
                var post = new Post()
                {
                    Title = collection["title"],
                    Content = collection["editor1"],
                    Picture = uploadBase,
                    Active = false,
                    PublishDate = DateTime.Now

                };
                var db = new sadecefikirlerEntities();
                db.Posts.Add(post);
                
                db.SaveChanges();
                Debug.Write(post.Title);
                
            }
            return View();
        }

    }
}