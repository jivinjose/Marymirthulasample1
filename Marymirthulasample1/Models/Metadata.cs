using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Marymirthulasample1.Models
{
    public class Register_tableMetadata
    {

        [Display(Name = "Name")]
        [Required(ErrorMessage = "This field can not be empty.")]
        public string name;

        [Display(Name = "Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email;

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string phone;

        [Required(ErrorMessage = "You must provide a user name")]
        [Display(Name = "User Name")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string username;

        [Required(ErrorMessage = "You must enter a password")]
        [MembershipPassword(
 MinRequiredNonAlphanumericCharacters = 1,
 MinNonAlphanumericCharactersError = "Your password needs to contain at least one symbol (!, @, #, etc).",
 ErrorMessage = "Your password must be 6 characters long and contain at least one symbol (!, @, #, etc).",
 MinRequiredPasswordLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("password", ErrorMessage = "Password and Confirmation Password must match.")]
        [Display(Name = "Confirm Password")]
        public string confirmpassword { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "You must provide a address")]
        [DataType(DataType.MultilineText)]
        public string address;

        [Display(Name = "Added Date")]
        public string datex;
    }
}