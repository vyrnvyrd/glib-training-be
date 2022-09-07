// <copyright file="IBorrowedBookRepository.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Abstract.Contracts;
using Garuda.Modules.BookLibrary.Models.Datas;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Models.Contracts
{
    /// <summary>
    /// Entity Group Contract Repository
    /// </summary>
    public interface IBorrowedBookRepository : IRepository
    {
        /// <summary>
        /// Get list borrowed book
        /// </summary>
        /// <returns>A <see cref="BorrowedBook"/> representing the asynchronous operation.</returns>
        Task<List<BorrowedBook>> GetData();

        /// <summary>
        /// Get list borrowed book by customer id
        /// </summary>
        /// <returns>A <see cref="BorrowedBook"/> representing the asynchronous operation.</returns>
        Task<List<BorrowedBook>> GetData(Guid CustomerId);

        /// <summary>
        /// Get data by book id and customer id
        /// </summary>
        /// <returns>A <see cref="BorrowedBook"/> representing the asynchronous operation.</returns>
        Task<BorrowedBook> GetData(Guid BookId, Guid CustomerId);

        /// <summary>
        /// Add or Update Data
        /// </summary>
        /// <returns>A <see cref="BorrowedBook"/> representing the asynchronous operation.</returns>
        Task AddOrUpdateData(BorrowedBook model);

        /// <summary>
        /// Update Return Book Data
        /// </summary>
        /// <returns>A <see cref="BorrowedBook"/> representing the asynchronous operation.</returns>
        Task UpdateReturnBookData(BorrowedBook model);
    }
}
