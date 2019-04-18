using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace udemy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string serialNumber { get; set; }
        public DateTime date_entered { get; set; }
    }
}