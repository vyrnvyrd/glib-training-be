// <copyright file="ErrorSaveExceptions.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;

namespace Garuda.Infrastructure.Errors
{
    public class ErrorSaveExceptions : Exception
    {
        public const string CustomError = "Error while saving data.";
        public const int Code = Codes.ERROR_TRANSACT;

        public ErrorSaveExceptions()
            : base(string.Format($"{CustomError}"))
        {
            Title = "Failed to save data";
            Message = CustomError;
        }

        public ErrorSaveExceptions(string customError)
          : base(string.Format($"{customError}"))
        {
            Title = "Failed to save data";
            Message = CustomError;
        }

        public ErrorSaveExceptions(string tittle, string customError)
           : base(string.Format($"{customError}"))
        {
            Title = tittle ?? "Failed to save data";
            Message = customError;
        }

        public string Title { get; set; }

        public string Message { get; set; }
    }
}
