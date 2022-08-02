// <copyright file="UserRepository.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Database.Framework;
using Garuda.Modules.BookLibrary.Models.Contracts;
using Garuda.Modules.BookLibrary.Models.Datas;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Models.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public async Task<List<Book>> GetData()
        {
            var datas = await this.dbSet.ToListAsync();
            return datas;
        }

        public async Task AddData(Book model)
        {
            var result = await this.dbSet.AddAsync(model);
        }
    }
}

