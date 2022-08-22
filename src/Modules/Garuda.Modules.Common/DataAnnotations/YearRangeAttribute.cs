// <copyright file="RegisterRequests.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;

namespace Garuda.Modules.Common.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class YearRangeAttribute : ValidationAttribute
    {
        public YearRangeAttribute() { }

        public string GetErrorMessage() => "The year must be before the current year";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;

            if (date.Year >= DateTime.Now.Year)
            {
                return new ValidationResult(GetErrorMessage());
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}