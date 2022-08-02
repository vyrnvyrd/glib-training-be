using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace Garuda.Modules.BookLibrary.Dtos.Request
{
    public class CreateBookRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Title
        /// </summary>
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Synopsis
        /// </summary>
        public string Synopsis { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Image Cover
        /// </summary>
        public IFormFile ImageCover { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Cover
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Released Date
        /// </summary>
        [Required(ErrorMessage = "Released Date is required.")]
        public DateTime ReleasedDate{ get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Author
        /// </summary>
        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Genre
        /// </summary>
        [Required(ErrorMessage = "Genre is required.")]
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Total Pages
        /// </summary>
        [Required(ErrorMessage = "Genre is required.")]
        public int TotalPages { get; set; }
    }
}
