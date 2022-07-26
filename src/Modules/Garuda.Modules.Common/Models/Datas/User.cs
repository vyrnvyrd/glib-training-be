// <copyright file="User.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Garuda.Abstract.Contracts;
using Garuda.Database.Framework;
using Garuda.Infrastructure.Models;
using Garuda.Modules.Common.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Garuda.Modules.Common.Models.Datas
{
    public class User : BaseModel, IEntity, IEntityRegister
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Fullname
        /// </summary>
        public string Fullname { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Username
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for IsActive
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for LastLogin
        /// </summary>
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for UserGroups
        /// </summary>
        public IList<UserGroup> UserGroups { get; set; } = new List<UserGroup>();

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for UserUnits
        /// </summary>
        public IList<UserUnit> UserUnits { get; set; } = new List<UserUnit>();

        /// <summary>
        /// Model builder to create it own model to declare field and relation.
        /// </summary>
        /// <param name="modelbuilder"></param>
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                .HasMaxLength(50);

                entity.Property(e => e.Fullname)
                .HasMaxLength(100);

                entity.Property(e => e.Username)
                .HasMaxLength(100);

                entity.Property(e => e.Password)
                .HasMaxLength(100);

                entity.Property(e => e.IsActive);

                entity.Property(e => e.LastLogin);

                entity.ToTable("Users");

                entity.HasData(
                    new User
                    {
                        Id = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        Email = "system@system.co",
                        IsActive = true,
                        Username = "systemadmin",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                        Fullname = "System",
                    },
                    new User
                    {
                        Id = Guid.Parse("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                        Email = "systemreserve@system.co",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Username = "systemadminreserve",
                        Fullname = "System Admin Reserve",
                    },
                    new User
                    {
                        Id = Guid.Parse("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                        Email = "rezacodym@gmail.com",
                        IsActive = true,
                        Username = "reza_reza",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                        Fullname = "Reza Muharam",
                    },
                    new User
                    {
                        Id = Guid.Parse("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                        Email = "atthoriqgf@gmail.com",
                        IsActive = true,
                        Username = "atthoriq_atthoriq",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                        Fullname = "Atthoriq",
                    },
                    new User
                    {
                        Id = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                        Email = "dermawanto_d@banpuindo.co.id",
                        IsActive = true,
                        Username = "dermawanto_d",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                        Fullname = "Dermawanto",
                    },
                    new User
                    {
                        Id = Guid.Parse("784d69e6-abc3-47f9-9245-9527d6b2f17c"),
                        Email = "vyrnvyrd@gmail.com",
                        IsActive = true,
                        Username = "firnafird",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                        Fullname = "Firna Firdiani",
                        Password = "2147c842e17c66dac7511400c9ff4755",
                    });
            });
        }
    }
}
