using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        /*public IActionResult DoLogin()
        {
            return View();
        }*/
        /*public IActionResult DoLogin(String txtUser, String txtpwd)
        {

            ViewData["userValue"] = $"{txtUser},{txtpwd}";
            return View();
        }*/
        public IActionResult DoLogin(String txtUser, String txtpwd)
        {
            ViewData["userValue"] = $"{txtUser},{txtpwd}";
            return View();
        }
        //localhost:5084/Home/Index
        public IActionResult SayHello(String name) //pass value 
        {
            if (String.IsNullOrEmpty(name)) 
                ViewData["v1"]="Name is Empty";
            else
            ViewData["v1"] = name;
            return View(); //checks with view folder -home-sayhello.cshtml
            //ViewData is a Dictionary where v1-key value in name is data (bussiness logic to presentation layer)
            //View data is limmited to the constrollwer which it is created and its corresponding view
            // we call it in presentation layer sayhello.cshtml
            //parameter name equal to value home/name=venkat "name"
            //Home/SayHello?name=Sangee name should be passed in route
        }
        public IActionResult Add(int x,int y)
        {
            int result = x + y;
            ViewData["result"] = result;
            return View();
            //localhost:5167/Home/Add?x=123&y=1
        }
        //i dont want to have differenet view keep it same html it is possible
        //return View("Add")
        // we can reuse this view for multiple methods
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["result"] = result;
            return View("Add");
            //localhost:5167/Home/Add?x=123&y=1
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["result"] = result;
            return View("Add");
            //localhost:5167/Home/Add?x=123&y=1
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

        //working with Book Object

        public IActionResult AddNewBook()
        {
            Book book = new Book();
            return View(book);
        }
        //html page
        //entire body is bounded
        public IActionResult SaveNewBook(Book pBook)
        {
            String fName = @"c:\temp\book.csv";
            string strBook = $"{pBook.BookID},{pBook.Title},{pBook.AuthorName},{pBook.Cost}";
            using(StreamWriter sw=new StreamWriter(fName, true))
            {
                sw.WriteLine(strBook);
            }
            return View(pBook);
        }
        public IActionResult ListAllBook()
        {
            String fName = @"c:\temp\book.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                string[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook=$"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }
            }
            return View(list);
        }
        private Book StringToBook(String[] data,Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }
    }
}