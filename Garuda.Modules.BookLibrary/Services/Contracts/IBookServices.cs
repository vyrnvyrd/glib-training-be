using Garuda.Modules.BookLibrary.Dtos.Responses;
using Garuda.Modules.Common.Dtos.Responses;
using Sieve.Models;
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
    }
}
