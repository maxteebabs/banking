using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace udemy.Models
{
    public class Min18YearsIfHasAccount : ValidationAttribute
    {
        protected override ValidationResult IsValid(Object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            if(customer.Dob == null)
            {
                return new ValidationResult("Date of Birth is required");
            }
            var age = DateTime.Today.Year - customer.Dob.Value.Year;
            if(age < 18)
            {
                return new ValidationResult("Customers should be atleast 18 years old to open an account");
            }
            return ValidationResult.Success;
        }
    }
}