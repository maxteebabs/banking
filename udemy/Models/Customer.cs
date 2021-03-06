﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace udemy.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Othernames { get; set; }

        public string Occupation { get; set; }

        [Min18YearsIfHasAccount]
        public DateTime? Dob { get; set; }
        
        public string Gender { get; set; }

        public string Address { get; set; }

        public string IsActive { get; set; }

        public DateTime? DateEntered { get; set; }

        public DateTime? Deleted { get; set; }

        public Account Account { get; set; }

        public int? AccountID { get; set; }

        public static readonly byte Male = 1;
        public static readonly byte Female = 2;
    }
}