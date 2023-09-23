using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics;
using System.Text;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //dependency based
        //passing value 3way using <a>
        public IActionResult Menu()
        {
            String conString = _configuration.GetConnectionString("DefaultConnection");
            _logger.Log(LogLevel.Information, conString);
            return View();
        }

        public ActionResult Echo(String name,String city)
        {
            String s1 = "user" + name + "from City=" + city;
            ViewData.Add("Data1", s1);
            return View();
        }
        public ActionResult SayHello(String name)
        {
            //Home/SayHello?name=Venkat
            String s1 = ("Hello " + name);
            ViewData.Add("Data1", s1);
            return View();
        }

        //Overloading method are not supported inmvc --give error multile endpoint --- decorate it with httppost
        [HttpPost]
       /* public ActionResult Index(int x)
        {
            ViewData["x"] = x;
            return View("IndexPost");
        }*/
        public ActionResult Index(int x,IFormCollection collection)
        {
            StringBuilder data = new StringBuilder(500);
            data.Append("x:");
            data.Append(x);
            data.Append(" ");
            data.Append("name:");
            data.Append(collection["name"]);
            data.Append(" ");
            data.Append("password:");
            data.Append(collection["password"]);
            
            /*foreach (var item in collection)
            {
                data.Append(item.Key);
                data.Append(":");
                data.Append(item.Value);
                data.Append(" ");
            }*/
            ViewData["x"] = data.ToString();
            return View("IndexPost");
        }

       /* public ActionResult DoTask(int? id) //parameter is nullable values or not
        {
            return View();
        }*/

        public ActionResult DoTask(int? id)//routing dont need oof id we explicitly given name as id
        {
            if (id.HasValue)
            {
                ViewData["id"] = id.Value;
            }
            else
            {
                ViewData["id"] = 0;
            }
                return View();
        }

        public ActionResult Test()
        {//every object return to page 
            //we use redirect to call action inti another action
            return RedirectToAction("Index");
        }
        
        public IActionResult GetBook()
        {
            Book b1 = new Book() { AuthorName = "H Leee" };
            ViewData["Book"] = b1;
            return View();
        }

        [ResponseCache(Duration =15)]
        public IActionResult GetTime()
        {
            String todate = DateTime.Now.ToLongTimeString();
            ViewData["date"] = todate;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}