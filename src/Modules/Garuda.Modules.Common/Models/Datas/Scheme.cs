// <copyright file="Scheme.cs" company="CV Garuda Infinity Kreasindo">
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
    public class Scheme : BaseModel, IEntity, IEntityRegister
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
        /// Gets or sets a value indicating whether gets or Sets for SchemeUnits.
        /// </summary>
        public IList<SchemeUnit> SchemeUnits { get; set; } = new List<SchemeUnit>();

        /// <summary>
        /// Model builder to create it own model to declare field and relation.
        /// </summary>
        /// <param name="modelbuilder"></param>
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Scheme>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                .HasMaxLength(100);

                entity.ToTable("Schemes");

                entity.HasData(
                new Scheme()
                {
                    Id = Guid.Parse("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                    Name = "Contractor",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                },
                new Scheme()
                {
                    Id = Guid.Parse("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                    Name = "Mine Closure",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                },
                new Scheme()
                {
                    Id = Guid.Parse("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                    Name = "Operation",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                });
            });
        }
    }
}
