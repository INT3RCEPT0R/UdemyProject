 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyProject.Models;
using UdemyProject.ViewModels;

namespace UdemyProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var viewResult = new ViewResult();
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
             
        } 
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}