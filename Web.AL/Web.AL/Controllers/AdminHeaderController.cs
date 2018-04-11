using System.Web.Mvc;
using Web.AL.Models;

namespace Web.AL.Controllers
{
    public class AdminHeaderController : Controller
    {
        [Authorize]
        public ActionResult UpdateHeader()
        {
            AdminHeaderViewModel adminHeaderViewModel = new AdminHeaderViewModel();
            return View(adminHeaderViewModel);
        }

        [HttpPost]
        [Authorize]
        public ActionResult UpdateHeader(AdminHeaderViewModel adminHeaderViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(adminHeaderViewModel);
            }

            TempData["AdminResult"]=adminHeaderViewModel.Update(adminHeaderViewModel);
            return RedirectToAction("Option", "AdminOption");
        }
    }
}