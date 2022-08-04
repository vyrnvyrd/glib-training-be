// <copyright file="BookController.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;
using Garuda.Modules.BookLibrary.Dtos.Request;
using Garuda.Modules.BookLibrary.Dtos.Responses;
using Garuda.Modules.BookLibrary.Services.Contracts;
using Garuda.Modules.Common.Dtos.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using System;
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

        /// GET: api/books
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
        /// <returns>A <see cref="APIResponses"/> representing the asynchronous operation.</returns>
        [HttpGet]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(APIResponses))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        public async Task<IActionResult> GetListBook(SieveModel model)
        {
            var result = await _bookServices.GetListBook(model);
            return Ok(result);
        }

        /// <summary>
        /// Get book by id.
        /// </summary>
        /// <returns>A <see cref="BookDetailResponses"/> representing the asynchronous operation.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(BookDetailResponses))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        public async Task<IActionResult> GetBookById(Guid id)
        {
            var result = await _bookServices.GetBookById(id);
            if (result == null)
            {
                return NotFound(ErrorConstant.NOT_FOUND);
            }

            return Ok(result);
        }

        /// POST: api/books
        /// <summary>
        /// Create book.
        /// </summary>
        /// <returns>A <see cref="MessageDto"/> representing the asynchronous operation.</returns>
        [HttpPost]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST)]
        public async Task<IActionResult> CreateBook([FromForm] CreateBookRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (model.ImageCover != null)
            {
                if (!CheckFileImage(model.ImageCover))
                {
                    return BadRequest(new { message = "Invalid file extension" });
                }

                if (model.ImageCover.Length > 1048576)
                {
                    return BadRequest(new { message = "Maximum allowed file size is 1MB" });
                }
            }

            var result = await _bookServices.CreateBook(model);
            return Ok(result);
        }

        /// PUT: api/books/{id}
        /// <summary>
        /// Update book.
        /// </summary>
        /// <returns>A <see cref="MessageDto"/> representing the asynchronous operation.</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST)]
        public async Task<IActionResult> Update(Guid id, [FromForm] UpdateBookRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (model.ImageCover != null)
            {
                if (!CheckFileImage(model.ImageCover))
                {
                    return BadRequest(new { message = "Invalid file extension" });
                }

                if (model.ImageCover.Length > 1048576)
                {
                    return BadRequest(new { message = "Maximum allowed file size is 1MB" });
                }
            }

            var result = await _bookServices.UpdateBook(id, model);
            return Ok(result);
        }

        /// DELETE: api/books/{id}
        /// <summary>
        /// Update book.
        /// </summary>
        /// <returns>A <see cref="MessageDto"/> representing the asynchronous operation.</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _bookServices.DeleteBook(id);
            return Ok(result);
        }

        private bool CheckFileImage(IFormFile file)
        {
            var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
            return (extension == ".jpg" || extension == ".png");
        }
    }
}
