using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using udemy.Models;

namespace udemy.DTOs
{
    public class CustomerDto
    {
        public int ID { get; set; }
        [Required]
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Othernames { get; set; }

        public string Occupation { get; set; }

        public DateTime? Dob { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string IsActive { get; set; }

        public DateTime? DateEntered { get; set; }

        public AccountDto Account { get; set; }
    }
}