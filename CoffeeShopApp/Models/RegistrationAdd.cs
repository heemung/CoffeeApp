﻿/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


no longer needed look in users Model forData 
namespace CoffeeShopApp.Models
{
    public class RegistrationAdd
    {
            
        [Required] // attributes 
        [RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression(@"^([A-z0-9]{5,30})@([A-z]{3,10}).([a-z]{2,3})$")]
        public string Email { set; get; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string PhoneNumber { set; get; }

        [Required]
        [RegularExpression(@"^[A-z0-9]{5,30}$")]
        public string Password { set; get; }

        public RegistrationAdd()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            Password = "";
        }
        public RegistrationAdd(string fn, string ln, string em, string ph, string pa)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            PhoneNumber = ph;
            Password = pa;
        }
    }
}
*/
