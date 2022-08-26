using AutoMapper;
using Garuda.Abstract.Contracts;
using Garuda.Database.Ldap.Contracts;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Contracts;
using Garuda.Infrastructure.Dtos;
using Garuda.Infrastructure.Errors;
using Garuda.Infrastructure.Exceptions;
using Garuda.Modules.BookLibrary.Dtos.Request;
using Garuda.Modules.BookLibrary.Models.Contracts;
using Garuda.Modules.BookLibrary.Models.Datas;
using Garuda.Modules.BookLibrary.Services.Contracts;
using Garuda.Modules.Common.Models.Contracts;
using Microsoft.Extensions.Logging;
using Sieve.Services;
using System;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Services.Repositories
{
    public class BorrowedBookServices : IBorrowedBookServices
    {
        private readonly IAuthLibraryService _authLibrary;
        private readonly IStorage _iStorage;
        private readonly IMapper _iMapper;
        private readonly SieveProcessor _sieve;
        private readonly ILogger _iLogger;
        private readonly IJwtFactory _jwt;
        public BorrowedBookServices(
            IAuthLibraryService authLibrary,
            IStorage iStorage,
            IMapper iMapper,
            SieveProcessor sieve,
            IJwtFactory jwt,
            ILogger<BookServices> iLogger)
        {
            _authLibrary = authLibrary;
            _iStorage = iStorage;
            _iMapper = iMapper;
            _sieve = sieve;
            _jwt = jwt;
            _iLogger = iLogger;
        }

        public async Task<MessageDto> CreateOrUpdateBorrowBook(BorrowBookRequest model)
        {
            try
            {
                _iLogger.LogInformation($"Check Existing Quantity Borrowed Book...");
                var datas = await _iStorage.GetRepository<IBorrowedBookRepository>().GetData(model.CustomerId);
                if (datas != null)
                {
                    var dataUser = await _iStorage.GetRepository<IUserRepository>().GetData(model.CustomerId);

                    int total = 0;
                    for(int i = 0; i < datas.Count; i++)
                    {
                        total = total + datas[i].BorrowedQuantity;
                    }

                    if (total >= 5)
                    {
                        throw new HttpResponseLibraryException(Codes.NOT_ACCEPTABLE, "Not Acceptable", $"Customer cannot borrow more than 5 books. Currently, customer {dataUser.Fullname} have borrowed {total} books");
                    }

                    if (total + model.BorrowedQuantity > 5)
                    {
                        throw new HttpResponseLibraryException(Codes.NOT_ACCEPTABLE, "Not Acceptable", $"Customer cannot borrow more than 5 books. Currently, customer {dataUser.Fullname} have borrowed {total} books. Proposed loan: {model.BorrowedQuantity}");
                    }
                }

                _iLogger.LogInformation($"Check Book Stock...");
                Book dataBook = await _iStorage.GetRepository<IBookRepository>().GetData(model.BookId);
                if (dataBook != null)
                {
                    if (model.BorrowedQuantity > dataBook.Stock)
                    {
                        throw new HttpResponseLibraryException(Codes.NOT_ACCEPTABLE, "Not Acceptable", $"Insufficient stock of books! remaining books : {dataBook.Stock}");
                    }
                }

                _iLogger.LogInformation($"Add or Update Borrowed Book...");
                var dataMapping = _iMapper.Map<BorrowBookRequest, BorrowedBook>(model);
                await _iStorage.GetRepository<IBorrowedBookRepository>().AddOrUpdateData(dataMapping);
                await _iStorage.SaveAsync();

                _iLogger.LogInformation($"Update Book Stock...");
                dataBook.Stock = dataBook.Stock - model.BorrowedQuantity;
                await _iStorage.GetRepository<IBookRepository>().UpdateData(dataBook.Id, dataBook);
                await _iStorage.SaveAsync();

                return new MessageDto("Data has been Updated", $"Book Successfully Borrowed");
            } catch
            {
                throw;
            }
        }
    }
}
