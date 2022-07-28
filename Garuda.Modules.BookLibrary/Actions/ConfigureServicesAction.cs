﻿// <copyright file="ConfigureServicesAction.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using Garuda.Infrastructure.Contracts;
using Garuda.Modules.BookLibrary.Services.Contracts;
using Garuda.Modules.BookLibrary.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Garuda.Modules.Auth.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
        {
            services.AddScoped<IBookServices, BookServices>();
        }
    }
}
