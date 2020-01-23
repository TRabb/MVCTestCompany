using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            //return View();
            return RedirectToAction("ListAllCustomers", "Customer");
        }

        public ActionResult CustomerNumber(string id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Your temporary customer number is: " + id);
            return View();
        }

        public string Company(string name)
        {
            return HttpUtility.HtmlEncode("Your company name is:" + name);
        }

        public string ListAllCustomers()
        {
            return @"<ul>
                     <li>Fred Flintstone</li>
                     <li>Judy Jetson</li>
                     <li>Shaggy Rogers</li>
                     <li>Daphne Blake</li>
                     </ul>";
        }
    }
}