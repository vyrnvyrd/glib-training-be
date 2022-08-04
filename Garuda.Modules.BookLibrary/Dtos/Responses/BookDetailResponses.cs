using System;

namespace Garuda.Modules.BookLibrary.Dtos.Responses
{
    public class BookDetailResponses
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Book ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Cover
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Synopsis
        /// </summary>
        public string Synopsis { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Released Date
        /// </summary>
        public DateTime ReleasedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Genre
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Total Pages
        /// </summary>
        public int TotalPages { get; set; }
    }
}
