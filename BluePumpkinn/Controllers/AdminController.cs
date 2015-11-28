using System.Web.Mvc;
using Microsoft.Owin.Host.SystemWeb;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Net;
using BluePumpkinn.Models;
using System.Linq;
using System.Data;
using PagedList;

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
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ApplicationUserManager UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            ApplicationRoleManager roleManager = HttpContext.GetOwinContext().Get<ApplicationRoleManager>();

            ViewBag.CurrentSort = sortOrder;
            ViewBag.FirstnameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.SurnameSortParm = sortOrder == "Surname" ? "surname_desc" : "Surname";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            string role = roleManager.FindByName("Employee").Id;
            var users = db.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(role));

            //Pagging
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            //Sorting
            if (!string.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.UserName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    users = users.OrderByDescending(s => s.Firstname);
                    break;
                case "Date":
                    users = users.OrderBy(s => s.BirthDate);
                    break;
                case "date_desc":
                    users = users.OrderByDescending(s => s.BirthDate);
                    break;
                case "Surname":
                    users = users.OrderBy(s => s.Surname);
                    break;
                case "surname_desc":
                    users = users.OrderByDescending(s => s.Surname);
                    break;
                default:
                    users = users.OrderBy(s => s.Firstname);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(users.ToPagedList(pageNumber, pageSize));

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
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Email")]ApplicationUser user)
            //public ActionResult Create([Bind(Include = "Name, EnrollmentDate")]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            ApplicationUser user = db.Users.Find(id);

            return View(user);
        }

       
        [HttpPost]
        public ActionResult Edit(string id)
        {
            var user = db.Users.Find(id);
            return View();
        }

        
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ApplicationUser user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}