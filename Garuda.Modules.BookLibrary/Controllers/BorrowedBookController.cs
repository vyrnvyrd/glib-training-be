using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;
using Garuda.Modules.BookLibrary.Dtos.Request;
using Garuda.Modules.BookLibrary.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        /// Initializes a new instance of the <see cref="BookController"/> class.
        /// </summary>
        /// <param name="bookServices"></param>
        public BorrowedBookController(
            IBorrowedBookServices borrowedBookServices)
        {
            _borrowedBookServices = borrowedBookServices;
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

    }
}
