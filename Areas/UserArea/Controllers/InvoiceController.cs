using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Inventory_System_Project.Models;

namespace MVC_Inventory_System_Project.Areas.UserArea.Controllers
{
    public class InvoiceController : Controller
    {
        BillingDBEntities db;
        public InvoiceController()
        {
            db = new BillingDBEntities();
        }
        // GET: UserArea/Invoice
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewInvoice()
        {
            return View();
        }

        [HttpPost]
        public string GenerateInvoice(tblinvice_details d)
        {
            db.tblinvice_details.Add(d);
            db.SaveChanges();
            return "Invoice Generated Sussessful";

        }
    }
}