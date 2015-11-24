using System.Web.Mvc;
using Microsoft.Owin.Host.SystemWeb;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Net;
using BluePumpkinn.Models;
using System.Linq;

namespace BluePumpkinn.Controllers
{
    [Authorize(Roles="Administrator")]
    public class AdminController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        //http://stackoverflow.com/questions/22847351/filter-user-list-asp-net-identity
        //http://stackoverflow.com/questions/26174576/initializing-rolemanager-in-asp-net-identity-with-custom-roles
        //http://stackoverflow.com/questions/23824397/get-list-of-users-with-assigned-roles-in-asp-net-identity-2-0
        //private RoleManager roleManager
        //{
        //    get
        //    {
        //        return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //    }
        //}

        // GET: Admin
        public ActionResult Index()
        {
            ApplicationUserManager UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            ApplicationRoleManager roleManager = HttpContext.GetOwinContext().Get<ApplicationRoleManager>();

            string role = roleManager.FindByName("Employee").Id;

            return View(db.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(role)).ToList());
            

            //return View(UserManager.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(role)).ToList());
        }

        public ActionResult Details(string id)
        {
            ApplicationUserManager UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ApplicationUser user = db.Users.Find(id);

            if (user == null)
            {
                return HttpNotFound();
            }
            return View();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

    }
}