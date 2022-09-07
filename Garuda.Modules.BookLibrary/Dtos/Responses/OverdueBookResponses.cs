using Sieve.Attributes;
using System;

namespace Garuda.Modules.BookLibrary.Dtos.Responses
{
    public class OverdueBookResponses
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Book ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Title
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Customer Name
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Due Date
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Duration
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public double Duration { get; set; }
    }
}
