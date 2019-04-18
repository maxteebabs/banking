using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using udemy.Models;

namespace udemy.ViewModels
{
    public class RandomMovie
    {
        public List<Customer> Customers { get; set; }
        public Product Product { get; set; }
    }
}