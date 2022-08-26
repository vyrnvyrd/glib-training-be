using System;

namespace Garuda.Modules.BookLibrary.Dtos.Request
{
    public class BorrowBookRequest
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
        /// Gets or sets a value indicating whether gets or sets for Borrowed Date
        /// </summary>
        public DateTime BorrowedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Borrowed Quantity
        /// </summary>
        public int BorrowedQuantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Due Date
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Returned Quantity
        /// </summary>
        public int ReturnedQuantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Remarks
        /// </summary>
        public string Remarks { get; set; }
    }
}
