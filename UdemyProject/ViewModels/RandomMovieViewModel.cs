using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyProject.Models;

namespace UdemyProject.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}