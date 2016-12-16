using sadecefikirler.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sadecefikirler.Controllers
{
    public class PartialManagerController : Controller
    {
        CategoryConcrete cc = new CategoryConcrete();
        TagsConcrete tc = new TagsConcrete();
        PostConcrete pc = new PostConcrete();
        // GET: PartialManager
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            return PartialView(cc.ListData());
        }

        [ChildActionOnly]
        public ActionResult TagsMenu()
        {
            return PartialView(tc.ListData());
        }

        [ChildActionOnly]
        public ActionResult PostPartial()
        {
            return PartialView(pc.ListData());
        }
    }
}