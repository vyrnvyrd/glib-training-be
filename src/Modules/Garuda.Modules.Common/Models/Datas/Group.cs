// <copyright file="Group.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using Garuda.Abstract.Contracts;
using Garuda.Database.Framework;
using Garuda.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Garuda.Modules.Common.Models.Datas
{
    public class Group : BaseModel, IEntity, IEntityRegister
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Name.
        /// </summary>
        public IList<UserGroup> UserGroups { get; set; } = new List<UserGroup>();

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for GroupMenuPermissions.
        /// </summary>
        public IList<GroupMenuPermission> GroupMenuPermissions { get; set; } = new List<GroupMenuPermission>();

        /// <summary>
        /// Model builder to create it own model to declare field and relation.
        /// </summary>
        /// <param name="modelbuilder"></param>
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Name);

                entity.ToTable("Groups");

                entity.HasData(
                    new Group()
                    {
                        Id = Guid.Parse("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                        Name = "Administrator",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    },
                    new Group()
                    {
                        Id = Guid.Parse("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                        Name = "QPB Administrator",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    },
                    new Group()
                    {
                        Id = Guid.Parse("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                        Name = "Mine Head",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    });
            });
        }
    }
}
