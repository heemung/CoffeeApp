using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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
        [RegularExpression(@"^([A-z0-9]{5,30})@([A-z]{5,10}).([a-z]{2,3})$")]
        public string Email { set; get; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string PhoneNumber { set; get; }

        public RegistrationAdd()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
        }
        public RegistrationAdd(string fn, string ln, string em, string ph)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            PhoneNumber = ph;
        }
    }
}
