using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SaveNewAuthor(Author pAuthor)
        {
            String fName = @"c:\temp\author.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.AuthorDateofBirth},{pAuthor.NoofBooksPublished},{pAuthor.Royaltycompany}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
            return View(pAuthor);
        }
        public IActionResult ListAllAuthor()
        {
            String fName = @"c:\temp\author.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strAuthor = $"{sr.ReadLine()}";
                string[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(',');
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        private Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.AuthorDateofBirth = DateTime.Parse(data[2]);
            author.NoofBooksPublished = (data[3]);
            author.Royaltycompany = (data[4]);
            return author;
        }
    }
}
