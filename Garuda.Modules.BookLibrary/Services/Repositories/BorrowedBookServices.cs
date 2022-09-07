using AutoMapper;
using Garuda.Abstract.Contracts;
using Garuda.Database.Ldap.Contracts;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Contracts;
using Garuda.Infrastructure.Dtos;
using Garuda.Infrastructure.Errors;
using Garuda.Infrastructure.Exceptions;
using Garuda.Modules.BookLibrary.Dtos.Request;
using Garuda.Modules.BookLibrary.Dtos.Responses;
using Garuda.Modules.BookLibrary.Models.Contracts;
using Garuda.Modules.BookLibrary.Models.Datas;
using Garuda.Modules.BookLibrary.Services.Contracts;
using Garuda.Modules.Common.Dtos.Responses;
using Garuda.Modules.Common.Models.Contracts;
using Microsoft.Extensions.Logging;
using Sieve.Models;
using Sieve.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<APIResponses> GetListOverdueBook(SieveModel sieveModel)
        {
            try
            {
                _iLogger.LogInformation("Getting data list book..");
                var borrowedBooks = await _iStorage.GetRepository<IBorrowedBookRepository>().GetData();

                if (borrowedBooks.Count() == 0)
                {
                    return new APIResponses()
                    {
                        Messages = "No books available.",
                        Data = new List<object>(),
                    };
                }

                var overdueBooks = borrowedBooks.Where(x => x.DueDate >= DateTime.Now)
                                                .OrderBy(x => x.DueDate)
                                                .Select(x => new OverdueBookResponses()
                                                {
                                                    Id = x.Id,
                                                    Title = x.Book.Title,
                                                    CustomerName = x.Customer.Fullname,
                                                    DueDate = x.DueDate,
                                                    Duration = (x.DueDate - DateTime.Now).TotalDays,
                                                }).ToList();
                var result = _sieve.Apply(sieveModel, overdueBooks.AsQueryable());
                _iLogger.LogInformation($"Data has been fetched. with data");

                return new APIResponses()
                {
                    Messages = "Books available.",
                    Data = result.Cast<object>().ToList(),
                };

            }
            catch (Exception ex)
            {
                throw ErrorConstant.BAD_REQUEST;
            }
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

        public async Task<MessageDto> ReturnBorrowBook(ReturnBookRequest model) 
        {
            try
            {
                _iLogger.LogInformation($"Check Existing Quantity Borrowed Book...");
                var datas = await _iStorage.GetRepository<IBorrowedBookRepository>().GetData(model.BookId, model.CustomerId);
                if (datas != null)
                {
                    if (datas.BorrowedQuantity != model.ReturnedQuantity)
                    {
                        throw new HttpResponseLibraryException(Codes.NOT_ACCEPTABLE, "Not Acceptable", $"Returned quantity should be the same as borrowed quantity");
                    }
                }
                _iLogger.LogInformation($"Add or Update Borrowed Book...");
                var dataMapping = _iMapper.Map<ReturnBookRequest, BorrowedBook>(model);
                await _iStorage.GetRepository<IBorrowedBookRepository>().UpdateReturnBookData(dataMapping);
                await _iStorage.SaveAsync();

                _iLogger.LogInformation($"Update Book Stock...");
                Book dataBook = await _iStorage.GetRepository<IBookRepository>().GetData(model.BookId);
                dataBook.Stock = dataBook.Stock + model.ReturnedQuantity;
                await _iStorage.GetRepository<IBookRepository>().UpdateData(dataBook.Id, dataBook);
                await _iStorage.SaveAsync();

                return new MessageDto("Data has been Updated", $"Book Successfully Returned");
            } catch
            {
                throw;
            }
        }
    }
}
