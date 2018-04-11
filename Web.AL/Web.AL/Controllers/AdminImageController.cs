using System.Web.Mvc;
using Web.AL.Models;

namespace Web.AL.Controllers
{
    public class AdminImageController : Controller
    {
        AdminImageViewModel adminImageViewModel = new AdminImageViewModel();

        [Authorize]
        public ActionResult DisplayImages()
        {
            return View(adminImageViewModel);
        }

        [Authorize]
        public ActionResult DeleteImageConfirmation(string imagePathToDelete)
        {
            adminImageViewModel.ImagePathToDelete = imagePathToDelete;
            return View(adminImageViewModel);
        }

        [Authorize]
        public ActionResult DeleteImage(string imagePathToDelete)
        {
            TempData["AdminResult"] = adminImageViewModel.DeleteImage(imagePathToDelete);
            return RedirectToAction("Option", "AdminOption");
        }
    }
}