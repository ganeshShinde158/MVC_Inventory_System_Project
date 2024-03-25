using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Inventory_System_Project.Areas.UserArea.Controllers
{
    public class DashboardController : Controller
    {
        // GET: UserArea/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}