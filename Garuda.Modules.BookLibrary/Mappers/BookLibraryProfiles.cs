using AutoMapper;
using Garuda.Modules.BookLibrary.Dtos.Request;
using Garuda.Modules.BookLibrary.Dtos.Responses;
using Garuda.Modules.BookLibrary.Models.Datas;

namespace Garuda.Modules.BookLibrary.Mappers
{
    /// <summary>
    /// Mapper.
    /// </summary>
    public class BookLibraryProfiles : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookLibraryProfiles"/> class.
        /// </summary>
        public BookLibraryProfiles()
        {
            CreateMap<Book, BookResponses>().ReverseMap();
            CreateMap<Book, CreateBookRequest>().ReverseMap();
            CreateMap<Book, UpdateBookRequest>().ReverseMap();
            CreateMap<Book, BookDetailResponses>().ReverseMap();
            CreateMap<BorrowedBook, BorrowBookRequest>().ReverseMap();
            CreateMap<BorrowedBook, ReturnBookRequest>().ReverseMap();
        }
    }
}
