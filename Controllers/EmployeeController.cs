using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
            if (t == "m")
            {
                ViewBag.Title = "Manager Index";
                return View("ManagerIndex");
            }
            else
            return View();
        }

        public ContentResult Search(string name)
        {
            var input = HttpUtility.HtmlEncode(name);
            return Content(input);
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
        [HttpPost]
        public ActionResult NewEmployee(string firstName, string lastName, string title)
        {
            ViewBag.Message = "Name: " + firstName + " " + lastName;
            ViewBag.Message = "     Title: " + title;
            return View("confirmEmployee");
        }

        public ActionResult NewEmployee()
        {
            return View("NewEmployeeForm");
        }
    }
}