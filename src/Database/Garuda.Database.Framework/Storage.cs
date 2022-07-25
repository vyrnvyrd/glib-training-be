// <copyright file="Storage.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Garuda.Abstract.Contracts;
using Garuda.Database.Framework.Data;
using Garuda.Database.Framework.Data.Contracts;
using Garuda.Database.Framework.Models.Audits.Configs;
using Garuda.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Garuda.Database.Framework
{
    public class Storage : IStorage
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IStorageContext StorageContext { get; private set; }

        public Storage(IStorageContext storageContext)
        {
            if (!(storageContext is DbContext))
            {
                throw new ArgumentException("The storageContext object must be an instance of the Microsoft.EntityFrameworkCore.DbContext class.");
            }

            this.StorageContext = storageContext;
        }

        public TRepository GetRepository<TRepository>()
            where TRepository : IRepository
        {
            TRepository repository = ExtensionManager.GetInstance<TRepository>();

            if (repository != null)
            {
                repository.SetStorageContext(this.StorageContext);
            }

            return repository;
        }

        public void Save()
        {
            var username = GetAuthenticatedUserName();

            UpdateSoftDeleteStatuses();
            new AuditLogHelper(this).AddAuditLogs(username);
            (this.StorageContext as DbContext).SaveChanges();
        }

        public async Task SaveAsync()
        {
            var username = GetAuthenticatedUserName();

            UpdateSoftDeleteStatuses();
            new AuditLogHelper(this).AddAuditLogs(username);
            await (this.StorageContext as DbContext).SaveChangesAsync();
        }

        private void UpdateSoftDeleteStatuses()
        {
            var _user = GetAuthenticatedUserId();
            foreach (var entry in (this.StorageContext as DbContext).ChangeTracker.Entries())
            {
                if (entry.Entity is AuditLog
                    || entry.State == EntityState.Detached
                    || entry.State == EntityState.Unchanged)
                {
                    continue;
                }

                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["CreatedDate"] = DateTime.Now;
                        entry.CurrentValues["CreatedBy"] = _user;
                        entry.CurrentValues["DeletedDate"] = null;
                        entry.CurrentValues["UpdatedDate"] = null;
                        entry.CurrentValues["UpdatedBy"] = null;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues["UpdatedDate"] = DateTime.Now;
                        entry.CurrentValues["UpdatedBy"] = _user;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["DeletedDate"] = DateTime.Now;
                        entry.CurrentValues["DeletedBy"] = _user;
                        break;
                }
            }
        }

        private Guid GetAuthenticatedUserId()
        {
            string id = _httpContextAccessor?.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Guid userId = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb");
            if (id != null)
            {
                userId = Guid.Parse(id);
            }

            return userId;
        }

        private string GetAuthenticatedUserName()
        {
            return "systemadmin";
        }
    }
}