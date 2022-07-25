// <copyright file="Unit.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garuda.Abstract.Contracts;
using Garuda.Database.Framework;
using Garuda.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Garuda.Modules.Common.Models.Datas
{
    public class Unit : BaseModel, IEntity, IEntityRegister
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
        /// Gets or sets a value indicating whether gets or Sets for SchemeUnits.
        /// </summary>
        public IList<UserUnit> UserUnits { get; set; } = new List<UserUnit>();

        /// <summary>
        /// Model builder to create it own model to declare field and relation.
        /// </summary>
        /// <param name="modelbuilder"></param>
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.ToTable("Units");

                entity.HasData(
                new Unit()
                {
                    Id = Guid.Parse("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                    Name = "IMM",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                },
                new Unit()
                {
                    Id = Guid.Parse("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                    Name = "Melak",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                },
                new Unit()
                {
                    Id = Guid.Parse("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                    Name = "KTD EMB",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                },
                new Unit()
                {
                    Id = Guid.Parse("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                    Name = "TRUST",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                },
                new Unit()
                {
                    Id = Guid.Parse("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                    Name = "JBG",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                },
                new Unit()
                {
                    Id = Guid.Parse("5b11f06f-426b-44f1-9023-170cb85797e3"),
                    Name = "KTD TDM",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                },
                new Unit()
                {
                    Id = Guid.Parse("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                    Name = "GPK",
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                });
            });
        }
    }
}
