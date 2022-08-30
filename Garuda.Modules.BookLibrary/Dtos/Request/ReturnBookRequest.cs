using System;

namespace Garuda.Modules.BookLibrary.Dtos.Request
{
    public class ReturnBookRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Book Id
        /// </summary>
        public Guid BookId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Customer Id
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Returned Quantity
        /// </summary>
        public int ReturnedQuantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Returned Date
        /// </summary>
        public DateTime ReturnedDate { get; set; }
    }
}
