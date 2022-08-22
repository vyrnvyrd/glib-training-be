// <copyright file="ErrorConstant.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Infrastructure.Dtos;
using Garuda.Infrastructure.Exceptions;

namespace Garuda.Infrastructure.Constants
{
    /// <summary>
    /// Error Constant
    /// Put every single message error in here.
    /// </summary>
    public class ErrorConstant
    {
        // Untuk menampilkan Source data
        public static readonly HttpResponseLibraryException UNAUTHORIZED = new HttpResponseLibraryException(Codes.UNAUTHORIZED, "Unauthorized user", "Unauthorized");
        public static readonly HttpResponseLibraryException INACTIVE_USER = new HttpResponseLibraryException(Codes.INACTIVE, "Inactive User", "Your account is inactive.");
        public static readonly HttpResponseLibraryException WRONG_USER = new HttpResponseLibraryException(Codes.NOT_FOUND, "Wrong User", "Incorrect Username/Password.");
        public static readonly HttpResponseLibraryException USERNAME_EXIST = new HttpResponseLibraryException(Codes.USERNAME_EXIST, "Username Exist", "Username already exists");

        public static readonly HttpResponseLibraryException INVALID_SESSION = new HttpResponseLibraryException(Codes.INVALID_SESSION, "Invalid Session", "Your session is invalid");

        public static readonly HttpResponseLibraryException NOT_FOUND = new HttpResponseLibraryException(Codes.INVALID_SESSION, "Not Found", "Data Not Found");

        public static readonly HttpResponseLibraryException TRANSACT_ERROR = new HttpResponseLibraryException(Codes.ERROR_TRANSACT, "Transact Failed", "Something went wrong on Transact Data");
        public static readonly HttpResponseLibraryException TRANSACT_SAVE = new HttpResponseLibraryException(Codes.ERROR_TRANSACT_SAVE, "Transact Failed", "Failed to save data");
        public static readonly HttpResponseLibraryException TRANSACT_UPDATE = new HttpResponseLibraryException(Codes.ERROR_TRANSACT_UPDATE, "Transact Failed", "Failed to update data");
        public static readonly HttpResponseLibraryException TRANSACT_DELETE = new HttpResponseLibraryException(Codes.ERROR_TRANSACT_DELETE, "Transact Failed", "Failed to delete data");
        public static readonly HttpResponseLibraryException TRANSACT_DUPLICATE = new HttpResponseLibraryException(Codes.ERROR_TRANSACT_DELETE, "Transact Failed", "Duplicated Data");

        public static readonly HttpResponseLibraryException BAD_REQUEST = new HttpResponseLibraryException(Codes.BAD_REQUEST, "Bad Request", "Invalid parameter value");
    }
}
