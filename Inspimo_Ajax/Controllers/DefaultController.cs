using Inspimo_Ajax.DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Inspimo_Ajax.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustomerList()
        {
            var jsonCustomer = JsonConvert.SerializeObject(context.Customers.ToList());
            return Json(jsonCustomer);
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            var values = JsonConvert.SerializeObject(customer);
            context.SaveChanges();
            return Json(values);
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Find(id);
            context.Customers.Remove(value);
            context.SaveChanges();
            return NoContent();
        }
        public IActionResult UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            var values= JsonConvert.SerializeObject(customer);
            context.SaveChanges();
            return Json(values);
        }
    }
}
