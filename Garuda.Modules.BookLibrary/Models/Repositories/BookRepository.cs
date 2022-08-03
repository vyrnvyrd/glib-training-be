// <copyright file="UserRepository.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Database.Framework;
using Garuda.Modules.BookLibrary.Models.Contracts;
using Garuda.Modules.BookLibrary.Models.Datas;
using Microsoft.EntityFrameworkCore;
using System;
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
            await this.dbSet.AddAsync(model);
        }

        public async Task UpdateData(Guid id, Book model)
        {
            var data = await this.dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if (data != null)
            {
                data.Title = model.Title;
                data.Cover = model.Cover;
                data.Synopsis = model.Synopsis;
                data.Author = model.Author;
                data.ReleasedDate = model.ReleasedDate;
                data.Genre = model.Genre;
                data.TotalPages = model.TotalPages;
                this.dbSet.Update(data);
            }
        }
    }
}

