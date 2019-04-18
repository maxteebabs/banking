using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace udemy.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dob { get; set; }
        public string gender { get; set; }
    }
}