using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SideProjectVidly.Models;
using SideProjectVidly.ViewModels;

namespace SideProjectVidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        [Route("movie/Rondom")]
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //011 Action Parameters-------------------------------------------
        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}

        //// movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = -1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }
        //    return Content(string.Format("pageIndex = {0}& sortBy = {1}", pageIndex, sortBy));
        //}
        [Route("movie/released/{year:max(2021)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}