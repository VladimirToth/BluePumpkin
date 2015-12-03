using BluePumpkinn.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace BluePumpkinn.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var user = db.Users.FirstOrDefault(a => a.BirthDate.Month == DateTime.Now.Month && a.BirthDate.Day == DateTime.Now.Day);
          
            if (user!=null)
            {
                //ViewBag.UserBirth = user.Firstname + " " + user.Surname;
                ViewBag.UserBirth = user;
            }
            else
            {
                ViewBag.UserBirth = user;
            }        
            return View();
        }


        [Authorize(Roles="Administrator")]
        public ActionResult About()
        {
            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [RequireHttps]
        public ActionResult EventForm(EventsModels model)
        {
            return View(model);

        }

         
    }
}