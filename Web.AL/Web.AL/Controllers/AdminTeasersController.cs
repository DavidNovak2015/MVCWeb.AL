using System.Web.Mvc;
using Web.AL.Models;
using System;

namespace Web.AL.Controllers
{
    public class AdminTeasersController : Controller
    {
        AdminTeasersViewModel adminTeasersViewModel = new AdminTeasersViewModel();

        [Authorize]
        public ActionResult Display()
        {
            return View(adminTeasersViewModel);
        }

        [Authorize]
        public ActionResult UpDateFromDisplay (int teaserId)
        {
            adminTeasersViewModel.IdTeaser = teaserId;
            adminTeasersViewModel.FindTeaser(adminTeasersViewModel);
            return View("TeaserForUpdate", adminTeasersViewModel);
        }
        [Authorize]
        public ActionResult Update()
        {
            return View(adminTeasersViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Update(AdminTeasersViewModel adminTeaserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(adminTeaserViewModel);
            }
            adminTeaserViewModel.FindTeaser(adminTeaserViewModel);
            return View("TeaserForUpdate", adminTeaserViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult UpdateTeaser(AdminTeasersViewModel adminTeaserViewModel)
        {
            if (adminTeaserViewModel.TeaserNew.Title == null || adminTeaserViewModel.TeaserNew.DateOfTeaser == DateTime.MinValue ||
                adminTeaserViewModel.TeaserNew.Title.Length > 50 || adminTeaserViewModel.TeaserNew.Text.Length > 3000
               )
            {
                return View("TeaserForUpdate",adminTeaserViewModel);
            }
            TempData["AdminResult"]=adminTeaserViewModel.UpdateTeaser(adminTeaserViewModel);
            return RedirectToAction("Option", "AdminOption");
        }
    }
}