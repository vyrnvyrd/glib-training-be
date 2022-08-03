// <copyright file="IBookRepository.cs" company="CV Garuda Infinity Kreasindo">
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
    public interface IBookRepository : IRepository
    {
        /// <summary>
        /// Get Data
        /// </summary>
        /// <returns>A <see cref="Book"/> representing the asynchronous operation.</returns>
        Task<List<Book>> GetData();

        /// <summary>
        /// Add Data
        /// </summary>
        /// <returns>A <see cref="Book"/> representing the asynchronous operation.</returns>
        Task AddData(Book model);

        /// <summary>
        /// Update Data
        /// </summary>
        /// <returns>A <see cref="Book"/> representing the asynchronous operation.</returns>
        Task UpdateData(Guid id, Book model);
    }
}