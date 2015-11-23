using System.Web.Mvc;
using Microsoft.Owin.Host.SystemWeb;
using System.Web;
using Microsoft.AspNet.Identity.Owin;

namespace BluePumpkinn.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Employees()
        {
            return View(UserManager.Users);
        }

        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }
    }
}