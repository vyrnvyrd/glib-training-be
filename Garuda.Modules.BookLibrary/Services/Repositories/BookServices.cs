using AutoMapper;
using Garuda.Abstract.Contracts;
using Garuda.Database.Ldap.Contracts;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Contracts;
using Garuda.Modules.BookLibrary.Dtos.Responses;
using Garuda.Modules.BookLibrary.Models.Contracts;
using Garuda.Modules.BookLibrary.Models.Datas;
using Garuda.Modules.BookLibrary.Services.Contracts;
using Garuda.Modules.Common.Dtos.Responses;
using Microsoft.Extensions.Logging;
using Sieve.Models;
using Sieve.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garuda.Modules.BookLibrary.Services.Repositories
{
    public class BookServices : IBookServices
    {
        private readonly IAuthLibraryService _authLibrary;
        private readonly IStorage _iStorage;
        private readonly IMapper _iMapper;
        private readonly SieveProcessor _sieve;
        private readonly ILogger _iLogger;
        private readonly IJwtFactory _jwt;

        public BookServices(
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

        public async Task<APIResponses> GetListBook(SieveModel sieveModel)
        {
            try
            {
                _iLogger.LogInformation("Getting data list book..");
                var books = await _iStorage.GetRepository<IBookRepository>().GetData();
                if (books.Count() > 0)
                {
                    var datas = _iMapper.Map<List<Book>, List<BookResponses>>(books.ToList());
                    var resultData = _sieve.Apply(sieveModel, datas.AsQueryable());

                    _iLogger.LogInformation($"Data has been fetched. with {datas.Count} data");
                    var result = new APIResponses()
                    {
                        Messages = "Books available.",
                        Data = (List<object>)(object)resultData.ToList(),
                    };
                    return result;
                }
                else
                {
                    var result = new APIResponses()
                    {
                        Messages = "No books available.",
                        Data = new List<object>(),
                    };

                    return result;
                }
            } catch (Exception ex)
            {
                throw ErrorConstant.BAD_REQUEST;
            }
        }
    }
}
