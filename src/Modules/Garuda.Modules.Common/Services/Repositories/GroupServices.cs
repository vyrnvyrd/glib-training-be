﻿// <copyright file="GroupServices.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Garuda.Abstract.Contracts;
using Garuda.Infrastructure.Constants;
using Garuda.Modules.Common.Dtos.Responses;
using Garuda.Modules.Common.Models.Contracts;
using Garuda.Modules.Common.Models.Datas;
using Garuda.Modules.Common.Services.Contracts;
using Microsoft.Extensions.Logging;

namespace Garuda.Modules.Common.Services.Repositories
{
    public class GroupServices : IGroupServices
    {
        private readonly IStorage _iStorage;
        private readonly ILogger _iLogger;
        private readonly IMapper _iMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupServices"/> class.
        /// </summary>
        /// <param name="iStorage"></param>
        /// <param name="iLogger"></param>
        /// <param name="iMapper"></param>
        public GroupServices(
            IStorage iStorage,
            ILogger<GroupServices> iLogger,
            IMapper iMapper)
        {
            _iStorage = iStorage;
            _iLogger = iLogger;
            _iMapper = iMapper;
        }

        public async Task<List<GroupResponses>> GetData(bool isActive)
        {
            try
            {
                _iLogger.LogInformation("Trying to get group data..");
                var datas = await _iStorage.GetRepository<IGroupRepository>().GetData(isActive);
                if (datas == null)
                {
                    datas = new List<Group>();
                }

                _iLogger.LogInformation($"Data has been fetched. with {datas.Count} data");
                var map = _iMapper.Map<List<Group>, List<GroupResponses>>(datas);
                return map;
            }
            catch (Exception)
            {
                throw ErrorConstant.BAD_REQUEST;
            }
        }
    }
}
