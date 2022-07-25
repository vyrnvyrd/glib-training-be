// <copyright file="ErrorHandlerMiddleware.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;
using Garuda.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Garuda.Infrastructure.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                _logger.LogInformation($"{error.Message}");
                switch (error)
                {
                    case HttpResponseLibraryException e:
                        response.StatusCode = e.Status;
                        await response.WriteAsJsonAsync(new MessageErrorDto(e.Status, e.Title, e.Message));
                        break;
                    default:
                        await response.WriteAsJsonAsync(new MessageErrorDto(500, "Oops! Something went wrong!", "Something went wrong"));
                        break;
                }
            }
        }
    }
}
