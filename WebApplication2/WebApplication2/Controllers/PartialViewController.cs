using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class PartialViewController : Controller
    {
        //GET: PartialView
        //Action->View calling view from action that is in controller
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good friends";
            return View();
        }
    }
}
