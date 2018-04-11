using System;
using System.Web.Mvc;
using Web.AL.Models;
using Web.DL;


namespace Web.AL.Controllers
{
    public class HomeController : Controller
    {
        PageViewModel page = new PageViewModel();
        public ActionResult Index()
        {            
            return View(page);
        }

        public ActionResult DisplayPageWithOneTeaser(int teaserId)
        {
            page.SetPageWithOneTeaser(teaserId);
            return View(page);
        }
    }
}