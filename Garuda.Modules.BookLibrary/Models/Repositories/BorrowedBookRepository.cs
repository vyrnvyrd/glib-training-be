// <copyright file="BorrowedBookRepository.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Database.Framework;
using Garuda.Modules.BookLibrary.Models.Contracts;
using Garuda.Modules.BookLibrary.Models.Datas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Models.Repositories
{
    public class BorrowedBookRepository : RepositoryBase<BorrowedBook>, IBorrowedBookRepository
    {
        public async Task<List<BorrowedBook>> GetData(Guid CustomerId)
        {
            return await this.dbSet.Where(x => x.CustomerId == CustomerId).ToListAsync();
        }

        public async Task AddOrUpdateData(BorrowedBook model)
        {
            var data = await this.dbSet.FirstOrDefaultAsync(x => x.BookId == model.BookId && x.CustomerId == model.CustomerId);
            if (data == null)
            {
                await this.dbSet.AddAsync(model);
                return;
            }

            data.BorrowedDate = model.BorrowedDate;
            data.BorrowedQuantity += model.BorrowedQuantity;
            data.DueDate = model.DueDate;
            data.ReturnedDate = model.ReturnedDate;
            data.Remarks = model.Remarks;
            this.dbSet.Update(data);
        }
    }
}
