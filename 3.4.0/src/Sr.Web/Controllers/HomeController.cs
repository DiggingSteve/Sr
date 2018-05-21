using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Sr.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SrControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}