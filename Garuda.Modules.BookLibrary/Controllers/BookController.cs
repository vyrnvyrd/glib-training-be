// <copyright file="BookController.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;
using Garuda.Modules.BookLibrary.Dtos.Responses;
using Garuda.Modules.BookLibrary.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/books")]
    public class BookController : Controller
    {
        private readonly IBookServices _bookServices;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookController"/> class.
        /// </summary>
        /// <param name="bookServices"></param>
        public BookController(
            IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        /// <summary>
        /// Get list of available books.
        /// </summary>
        /// <returns>A <see cref="BookResponses"/> representing the asynchronous operation.</returns>
        [HttpGet]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(List<BookResponses>))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        public async Task<IActionResult> GetListBook(SieveModel model)
        {
            var result = await _bookServices.GetListBook(model);
            return Ok(result);
        }
    }
}
