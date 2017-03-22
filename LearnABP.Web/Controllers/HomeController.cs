using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace LearnABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LearnABPControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}