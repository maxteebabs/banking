using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace udemy.DTOs
{
    public class AccountDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AccountType { get; set; }
        public DateTime DateEntered { get; set; }
        public float Balance { get; set; }
        public Boolean Status { get; set; }
    }
}