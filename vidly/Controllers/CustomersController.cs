using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
            {
                new Customer {Name="John Smith", Id= 1},
                new Customer { Name= "Mary Williams", Id=2}
            };

        public ActionResult Index()
        {


            var viewModel = new ListCostumersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult GetCustomer(int id)
        {
            foreach(var c in customers)
            {
                if (c.Id == id)
                {
                    return View(c);
                }
                else
                {
                    continue;
                }
            }
            return HttpNotFound();

        }
    }
}