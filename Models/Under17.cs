using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Under17:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
{
            var customer = (Customer) validationContext.ObjectInstance;
 	     if (customer.MembershipTypeId== MembershipType.Unknown || customer.MembershipTypeId==MembershipType.PayAsYouGo)
             return ValidationResult.Success;

            if (customer.Birthdate ==null)
                return new ValidationResult("Birthdate Required Field please enter Birhdate ! ");
            
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year ; 

            return (age >= 18 ) ? 
                ValidationResult.Success 
                : new ValidationResult("Member should be over 18");
                
            {
		 
	}
	{
		 
	}
	{
		 
	}
}
    }
}