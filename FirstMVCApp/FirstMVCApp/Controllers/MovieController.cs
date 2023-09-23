using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
            List<Movie> movielist = MovieDbRepository.GetMovieList();
            return View(movielist);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            if (id < 0)
            {
                return RedirectToAction("Index");
            }
            Movie movie = MovieDbRepository.FindMovieById(id);
            return View(movie);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            Movie movie = new Movie();
            return View(movie);
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MovieDbRepository.AddNewMovieDetails(movie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            Movie movie = MovieDbRepository.FindMovieById(id);
            return View(movie);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MovieDbRepository.UpdateMovieDetails(movie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            Movie movie = MovieDbRepository.FindMovieById(id);
            if (movie != null)
                return View(movie);
            return View(movie);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                MovieDbRepository.DeleteMovieDetails(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
