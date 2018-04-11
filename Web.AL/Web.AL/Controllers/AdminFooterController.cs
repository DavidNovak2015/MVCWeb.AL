using System.Web.Mvc;
using Web.AL.Models;

namespace Web.AL.Controllers
{
    public class AdminFooterController : Controller
    {
        [Authorize]
        public ActionResult UpdateFooter()
        {
            AdminFooterViewModel adminFooterViewModel = new AdminFooterViewModel();
            return View(adminFooterViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult UpdateFooter(AdminFooterViewModel adminFooterViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(adminFooterViewModel);
            }
            TempData["AdminResult"]=adminFooterViewModel.Update(adminFooterViewModel);
            return RedirectToAction("Option", "AdminOption");
        }
    }
}