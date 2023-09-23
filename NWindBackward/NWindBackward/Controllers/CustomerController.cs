using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NWindBackward.Models;

namespace NWindBackward.Controllers
{
    public class CustomerController : Controller
    {
        private RepositoryCustomer _repositoryCustomer;
        public CustomerController(RepositoryCustomer repositoryCustomer)
        {
            _repositoryCustomer = repositoryCustomer;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            List<Customer> customers = _repositoryCustomer.GetAllCustomer();
            CustomerViewModel viewModel = new CustomerViewModel(customers);
            return View(viewModel);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {
            Customer customer = _repositoryCustomer.GetCustomerByID(id);

            /*            // Check if customer exists
                        if (customer == null)
                        {
                            // Return an error view or redirect to another action
                            return View("Error", new ErrorViewModel());
                            // OR
                            // return RedirectToAction("Index");
                        }*/

            List<Order> orders = _repositoryCustomer.FindOrdersByCustomerID(customer.CustomerId);
            ViewData["Orders"] = orders;

            return View(customer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
