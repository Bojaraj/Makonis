using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMk.Models;
using TestMk.Repository;
using System.ComponentModel.DataAnnotations;


namespace TestMk.Controllers
{
    public class HomeController : Controller
    {
        private CustomerDBEntities objCustomerDBEntities;
        public HomeController()
        {
            objCustomerDBEntities = new CustomerDBEntities();
        }

        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Customer objCust)
        {
            if (ModelState.IsValid)
            {
                CustomerRepository custRepo = new CustomerRepository(objCustomerDBEntities);
                custRepo.Add(objCust);
                return View("thankyou");

            }

            return View();
        }

      
    }
}