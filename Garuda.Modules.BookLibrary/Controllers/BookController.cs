﻿// <copyright file="BookController.cs" company="CV Garuda Infinity Kreasindo">
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
        /// Create book.
        /// </summary>
        /// <returns>A <see cref="APIResponses"/> representing the asynchronous operation.</returns>
        [HttpPost]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(APIResponses))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST)]
        public async Task<IActionResult> CreateBook([FromForm] CreateBookRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!CheckFileImage(model.ImageCover))
            {
                return BadRequest(new { message = "Invalid file extension" });
            }

            if (model.ImageCover.Length > 1048576)
            {
                return BadRequest(new { message = "Maximum allowed file size is 1MB" });
                }

            var result = await _bookServices.CreateBook(model);
            return Ok(result);
        }

        private bool CheckFileImage(IFormFile file)
        {
            var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
            return (extension == ".jpg" || extension == ".png");
        }
    }
}
