// <copyright file="IAuditDbContext.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Garuda.Database.Framework.Data.Contracts
{
    public interface IAuditDbContext
    {
        DbSet<AuditLog> AuditLogs { get; set; }

        ChangeTracker ChangeTracker { get; }
    }
}
