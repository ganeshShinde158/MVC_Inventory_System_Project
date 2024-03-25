using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Inventory_System_Project.Models;

namespace MVC_Inventory_System_Project.Areas.UserArea.Controllers
{
    public class CustomerController : Controller
    {
        BillingDBEntities db;
        public CustomerController()
        {
            db = new BillingDBEntities();
        }

        // GET: UserArea/Customer
        public ActionResult Index()
        {
            List<tblcustomer> lst = db.tblcustomers.ToList();
            return View(lst);
        }

        public JsonResult GetCustomers()
        {
            List<tblcustomer> customerList = new List<tblcustomer>();

            foreach (tblcustomer c in db.tblcustomers.ToList())
            {
                tblcustomer tc = new tblcustomer()
                {
                    Customer_id = c.Customer_id,
                    Customer_name = c.Customer_name,
                    City = c.City,
                    Email_address = c.Email_address,
                    mobile_number = c.mobile_number
                };

                customerList.Add(tc);
            }

            return Json(customerList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCustomer(int id)
        {
            tblcustomer cs = db.tblcustomers.Find(id);
            return Json(cs, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public string AddCustomerData(tblcustomer st)
        {
            db.tblcustomers.Add(st);
            db.SaveChanges();
            return "Customer Added Successfully";
        }

        [HttpPost]
        public string UpdateCustomerData(tblcustomer st)
        {
            db.Entry<tblcustomer>(st).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Customer Updated Successfully";
        }

        [HttpPost]
        public string DeleteCustomerData(int id)
        {
            tblcustomer cs = db.tblcustomers.Find(id);
            db.tblcustomers.Remove(cs);
            db.SaveChanges();
            return "Customer Deleted Successfully";
        }
    }
}