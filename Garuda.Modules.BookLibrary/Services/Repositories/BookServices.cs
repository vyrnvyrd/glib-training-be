using AutoMapper;
using Garuda.Abstract.Contracts;
using Garuda.Database.Ldap.Contracts;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Contracts;
using Garuda.Infrastructure.Dtos;
using Garuda.Infrastructure.Errors;
using Garuda.Modules.BookLibrary.Dtos.Request;
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
using System.IO;
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
                
                if (books.Count() == 0)
                {
                    return new APIResponses()
                    {
                        Messages = "No books available.",
                        Data = new List<object>(),
                    };
                }

                var datas = _iMapper.Map<List<Book>, List<BookResponses>>(books.ToList());
                var result = _sieve.Apply(sieveModel, datas.AsQueryable());
                _iLogger.LogInformation($"Data has been fetched. with {datas.Count} data");
                
                return new APIResponses()
                {
                    Messages = "Books available.",
                    Data = result.Cast<object>().ToList(),
                };

            } catch (Exception ex)
            {
                throw ErrorConstant.BAD_REQUEST;
            }
        }

        public async Task<MessageDto> CreateBook(CreateBookRequest model)
        {
            try
            {
                _iLogger.LogInformation($"Save Image...");
                if (model.ImageCover != null)
                {
                    string fileName;
                    try
                    {
                        var extension = "." + model.ImageCover.FileName.Split('.')[model.ImageCover.FileName.Split('.').Length - 1];
                        fileName = DateTime.Now.Ticks + extension; //Create a new Name for the file due to security reasons.

                        var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files");

                        if (!Directory.Exists(pathBuilt))
                        {
                            Directory.CreateDirectory(pathBuilt);
                        }

                        var path = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files",
                           fileName);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await model.ImageCover.CopyToAsync(stream);
                        }

                        model.Cover = fileName;
                    }
                    catch (Exception ex)
                    {
                        throw new ErrorSaveExceptions($"Saving Image file is failed : {ex.Message}");
                    }
                }

                _iLogger.LogInformation($"Saving Book data...");
                var data = _iMapper.Map<CreateBookRequest, Book>(model);
                await _iStorage.GetRepository<IBookRepository>().AddData(data);
                await _iStorage.SaveAsync();

                _iLogger.LogInformation($"Book Successfully Saved");
                return new MessageDto("Data has been Saved", $"Book {data.Title} Successfully Saved");
            } catch (Exception ex)
            {
                throw new ErrorSaveExceptions($"Saving Book is failed : {ex.Message}");
            }
        }

        public async Task<MessageDto> UpdateBook(Guid id,UpdateBookRequest model)
        {
            try
            {
                _iLogger.LogInformation($"Save Image...");
                if (model.ImageCover != null)
                {
                    string fileName;
                    try
                    {
                        var extension = "." + model.ImageCover.FileName.Split('.')[model.ImageCover.FileName.Split('.').Length - 1];
                        fileName = DateTime.Now.Ticks + extension; //Create a new Name for the file due to security reasons.

                        var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files");

                        if (!Directory.Exists(pathBuilt))
                        {
                            Directory.CreateDirectory(pathBuilt);
                        }

                        var path = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files",
                           fileName);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await model.ImageCover.CopyToAsync(stream);
                        }

                        model.Cover = fileName;
                    }
                    catch (Exception ex)
                    {
                        throw new ErrorSaveExceptions($"Saving Image file is failed : {ex.Message}");
                    }
                }

                _iLogger.LogInformation($"Update Book data...");
                var data = _iMapper.Map<UpdateBookRequest, Book>(model);
                await _iStorage.GetRepository<IBookRepository>().UpdateData(id, data);
                await _iStorage.SaveAsync();

                _iLogger.LogInformation($"Book Successfully Updated");
                return new MessageDto("Data has been Updated", $"Book {data.Title} Successfully Updated");
            }
            catch (Exception ex)
            {
                throw new ErrorSaveExceptions($"Updating Book is failed : {ex.Message}");
            }
        }
    }
}
