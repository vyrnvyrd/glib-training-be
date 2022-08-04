using Garuda.Infrastructure.Dtos;
using Garuda.Modules.BookLibrary.Dtos.Request;
using Garuda.Modules.BookLibrary.Dtos.Responses;
using Garuda.Modules.Common.Dtos.Responses;
using Sieve.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Services.Contracts
{
    public interface IBookServices
    {
        /// <summary>
        /// Get list of available book
        /// </summary>
        /// <param name="sieveModel"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<APIResponses> GetListBook(SieveModel sieveModel);

        /// <summary>
        /// Get book by id
        /// </summary>
        /// <param name="sieveModel"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<BookDetailResponses> GetBookById(Guid id);

        /// <summary>
        /// Create book
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<MessageDto> CreateBook(CreateBookRequest model);

        /// <summary>
        /// Update book
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<MessageDto> UpdateBook(Guid id, UpdateBookRequest model);

        /// <summary>
        /// Delete book
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<MessageDto> DeleteBook(Guid id);
    }
}
