// <copyright file="UserUnit.cs" company="CV Garuda Infinity Kreasindo">
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
    public class UserUnit : BaseModel, IEntity, IEntityRegister
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for UserId.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for User.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for UnitId.
        /// </summary>
        public Guid UnitId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Unit.
        /// </summary>
        public Unit Unit { get; set; }

        /// <summary>
        /// Model builder to create it own model to declare field and relation.
        /// </summary>
        /// <param name="modelbuilder"></param>
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<UserUnit>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(e => e.User)
                .WithMany(e => e.UserUnits)
                .HasForeignKey(e => e.UserId);

                entity.HasOne(e => e.Unit).
                WithMany(e => e.UserUnits)
                .HasForeignKey(e => e.UnitId);

                entity.ToTable("UserUnits");

                entity.HasData(
                    new UserUnit()
                    {
                        Id = Guid.Parse("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                        UserId = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                        UnitId = Guid.Parse("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    },
                    new UserUnit()
                    {
                        Id = Guid.Parse("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                        UserId = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                        UnitId = Guid.Parse("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    },
                    new UserUnit()
                    {
                        Id = Guid.Parse("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                        UserId = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                        UnitId = Guid.Parse("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    },
                    new UserUnit()
                    {
                        Id = Guid.Parse("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                        UserId = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                        UnitId = Guid.Parse("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    },
                    new UserUnit()
                    {
                        Id = Guid.Parse("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                        UserId = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                        UnitId = Guid.Parse("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    },
                    new UserUnit()
                    {
                        Id = Guid.Parse("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                        UserId = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                        UnitId = Guid.Parse("5b11f06f-426b-44f1-9023-170cb85797e3"),
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = DateTime.Now,
                    },
                    new UserUnit()
                    {
                    Id = Guid.Parse("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                    UserId = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                    UnitId = Guid.Parse("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                    CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                    CreatedDate = DateTime.Now,
                    });
            });
        }
    }
}
