using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieShop.Core.Models.Request
{
    public class UserRegisterRequestModel
    {
        [Required]
        [EmailAddress]
        [StringLength(50, MinimumLength =0)]
        public string Email { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Make sure password is right length", MinimumLength =8)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage = "Password Should have minimum 8 with at least one upper, lower, number and special character")]
        public string Password { get; set; }

        [StringLength(50, MinimumLength = 0)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 0)]
        public string LastName { get; set; }

        //if you wanna create your own validation, you can create a custom class that derives from ValidationAttribute
    }
}
