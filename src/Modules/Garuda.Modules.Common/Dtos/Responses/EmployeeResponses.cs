// <copyright file="EmployeeResponses.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using Sieve.Attributes;

namespace Garuda.Modules.Common.Dtos.Responses
{
    /// <summary>
    /// Dto for Employee.
    /// </summary>
    public class EmployeeResponses
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Name.
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Fullname.
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string Fullname { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for EmployeeCode.
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for PhoneNumber.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for DateStart.
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime? DateStart { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for DateEnd.
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime? DateEnd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Address.
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for State.
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for City.
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string City { get; set; }
    }
}
