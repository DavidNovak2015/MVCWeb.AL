using System.Web.Mvc;

namespace Web.AL.Controllers
{
    public class AdminOptionController : Controller
    {
        [Authorize]
        public ActionResult Option()
        {
            return View();
        }
    }
}