﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyProject.Models;

namespace UdemyProject.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            //return View(movie);
            //return Content("Hello world!");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index","Home", new { page = 1, sortBy = "name"});
        }
    }
}