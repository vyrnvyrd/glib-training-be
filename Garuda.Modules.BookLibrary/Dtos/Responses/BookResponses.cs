using Sieve.Attributes;
using System;
using System.Collections.Generic;

namespace Garuda.Modules.BookLibrary.Dtos.Responses
{
    public class BookResponses
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
        /// Gets or sets a value indicating whether gets or sets for Author
        /// </summary>
        [Sieve(CanFilter = true, CanSort = true)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Cover
        /// </summary>
        public string Cover { get; set; }
    }
}
