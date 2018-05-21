using System.Web.Mvc;

namespace Sr.Web.Controllers
{
    public class AboutController : SrControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}