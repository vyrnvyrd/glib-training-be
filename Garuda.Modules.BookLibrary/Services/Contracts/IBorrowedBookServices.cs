using Garuda.Infrastructure.Dtos;
using Garuda.Modules.BookLibrary.Dtos.Request;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Services.Contracts
{
    public interface IBorrowedBookServices
    {
        /// <summary>
        /// Add or update borrow book
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<MessageDto> CreateOrUpdateBorrowBook(BorrowBookRequest model);

        /// <summary>
        /// Return borrow book
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<MessageDto> ReturnBorrowBook(ReturnBookRequest model);
    }
}
