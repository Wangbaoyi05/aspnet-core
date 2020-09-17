using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPUnity01.Controllers;

namespace ABPUnity01.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPUnity01ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
