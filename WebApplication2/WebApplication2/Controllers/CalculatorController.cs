using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{ //calling view-> action
    //invoking an action from a view
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Add(int x,int y)
        {
            return x + y;
        }
    }
}
