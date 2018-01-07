using CustomResultMVC.Infrastructure;
using CustomResultMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomResultMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetEmployeeDetails()
        {
            var list = new Employee();
            var a = new Employee() { Name = "Dhiren" };
            var b = new Employee() { Name = "Vatsal" };
            var c = new Employee() { Name = "Mihir" };
            var d = new Employee() { Name = "Riddhesh" };
            var EmployeeList = new List<Employee>();
            EmployeeList.Add(a);
            EmployeeList.Add(b);
            EmployeeList.Add(c);
            EmployeeList.Add(d);

            return new CSVResult(EmployeeList, "Employee");
        }
    }
}