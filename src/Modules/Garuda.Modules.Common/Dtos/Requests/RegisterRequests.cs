// <copyright file="RegisterRequests.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;
using Garuda.Modules.Common.DataAnnotations;

namespace Garuda.Modules.Common
{
    public class RegisterRequests
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [RegularExpression("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "Username required and must be properly formatted.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Maximum 30 characters")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Maximum 100 characters")]
        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Display(Name = "BirthDate")]
        [YearRange]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Privacy Policy")]
        public string PrivacyPolicy { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
