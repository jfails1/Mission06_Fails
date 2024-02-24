using Microsoft.AspNetCore.Mvc;
using Mission06_Fails.Models;
using System.Diagnostics;

namespace Mission06_Fails.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;
        public HomeController(MovieCollectionContext temp) // Constructor
        { 
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.categories = _context.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            _context.Movies.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response); 
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult MovieList ()
        {
            var movies = _context.Movies
                .Where(x => x.Year > 1888)
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }
    }
}
