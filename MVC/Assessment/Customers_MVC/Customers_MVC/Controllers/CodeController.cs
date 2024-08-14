using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customers_MVC.Models; 

namespace Customers_MVC.Controllers
{
    public class CodeController : Controller
    {
        public northwindEntities db = new northwindEntities();

       
        public ActionResult CustomersInGermany()
        {
            var customers = db.Customers
                              .Where(c => c.Country == "Germany")
                              .ToList();

            return View(customers);
        }

        public ActionResult CustomerDetailsForOrder(int orderId = 10248)
        {
            var order = db.Orders
                          .Where(o => o.OrderID == orderId)
                          .Select(o => o.Customer)
                          .FirstOrDefault();

            return View(order);
        }
    }
}