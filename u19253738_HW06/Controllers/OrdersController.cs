using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using u19253738_HW06.Models;
using PagedList.Mvc;
using PagedList;



namespace u19253738_HW06.Controllers
{
    public class OrdersController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();

        // GET: Orders
        public ActionResult Index(int? i)
        {

            var orders = db.order_items;
            return View(orders.ToList().ToPagedList(i ?? 1, 10));
        }

        
    }
}
