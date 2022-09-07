using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;
using Garuda.Modules.BookLibrary.Dtos.Request;
using Garuda.Modules.BookLibrary.Services.Contracts;
using Garuda.Modules.Common.Dtos.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using System;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/borrow-book")]
    public class BorrowedBookController : Controller
    {
        private readonly IBorrowedBookServices _borrowedBookServices;

        /// GET: api/books
        /// <summary>
        /// Initializes a new instance of the <see cref="BorrowedBookController"/> class.
        /// </summary>
        /// <param name="borrowedBookServices"></param>
        public BorrowedBookController(
            IBorrowedBookServices borrowedBookServices)
        {
            _borrowedBookServices = borrowedBookServices;
        }

        /// <summary>
        /// Get list of overdue books.
        /// </summary>
        /// <returns>A <see cref="APIResponses"/> representing the asynchronous operation.</returns>
        [HttpGet]
        [Route("overdue")]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(APIResponses))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        public async Task<IActionResult> GetListOverdueBook(SieveModel model)
        {
            var result = await _borrowedBookServices.GetListOverdueBook(model);
            return Ok(result);
        }

        /// POST: api/borrow-book
        /// <summary>
        /// Borrow book.
        /// </summary>
        /// <returns>A <see cref="MessageDto"/> representing the asynchronous operation.</returns>
        [HttpPost]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST)]
        public async Task<IActionResult> Borrow([FromBody] BorrowBookRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _borrowedBookServices.CreateOrUpdateBorrowBook(model);
            return Ok(result);
        }

        /// POST: api/borrow-book/return
        /// <summary>
        /// Return book.
        /// </summary>
        /// <returns>A <see cref="MessageDto"/> representing the asynchronous operation.</returns>
        [HttpPost]
        [Route("return")]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST)]
        public async Task<IActionResult> Return([FromBody] ReturnBookRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _borrowedBookServices.ReturnBorrowBook(model);
            return Ok(result);
        }
    }
}
