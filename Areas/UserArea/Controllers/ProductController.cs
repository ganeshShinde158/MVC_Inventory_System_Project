using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Inventory_System_Project.Models;


namespace MVC_Inventory_System_Project.Areas.UserArea.Controllers
{
    public class ProductController : Controller
    {
        BillingDBEntities db;
        public ProductController()
        {
            db = new BillingDBEntities();
        }
        // GET: UserArea/Product
        public ActionResult Index()
        {
            List<tblproduct> lst = db.tblproducts.ToList();
            return View(lst);
        }
        public JsonResult GetItems()
        {
            List<tblproduct> lst = new List<tblproduct>();
            foreach (tblproduct t in db.tblproducts.ToList())
            {
                tblproduct m = new tblproduct()
                {
                    Product_id = t.Product_id,
                    Product_name = t.Product_name,
                    Rate = t.Rate,
                    Tax = t.Tax,
                    Stock_quantity = t.Stock_quantity
                };

                lst.Add(m);
            }

            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetItem(int id)
        {
            tblproduct cs = db.tblproducts.Find(id);
            cs.tblinvice_products = null;
            return Json(cs, JsonRequestBehavior.AllowGet);
        }
        
       
        [HttpPost]
        public string UpdateItemData(tblproduct st)
        {
            db.Entry<tblproduct>(st).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Item Updated Successfully";
        }

        [HttpPost]
        public string DeleteItemData(int id)
        {
            tblproduct cs = db.tblproducts.Find(id);
            db.tblproducts.Remove(cs);
            db.SaveChanges();
            return "Product Deleted Successfully";
        }
        public string AddProductData(tblproduct st)
        {
            db.tblproducts.Add(st);
            db.SaveChanges();
            return "Product Added Successfully";
        }
    }
}