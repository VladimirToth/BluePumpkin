using System.Web.Mvc;
using Microsoft.Owin.Host.SystemWeb;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Net;
using BluePumpkinn.Models;
using System.Linq;

namespace BluePumpkinn.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View(UserManager.Users);
        }

        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
           // ApplicationUser user = UserManager.Users.Where(a => a.Id == id);

            //if (user == null)
            //{
            //    return HttpNotFound();
            //}
            return View();
        }

    }
}