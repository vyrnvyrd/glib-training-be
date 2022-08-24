// <copyright file="BorrowedBook.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using Garuda.Abstract.Contracts;
using Garuda.Database.Framework;
using Garuda.Infrastructure.Models;
using Garuda.Modules.Common.Models.Datas;
using Microsoft.EntityFrameworkCore;

namespace Garuda.Modules.BookLibrary.Models.Datas
{
    public class BorrowedBook : BaseModel, IEntity, IEntityRegister
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Book Id
        /// </summary>
        public Guid BookId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Book
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Customer Id
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Book
        /// </summary>
        public User Customer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Borrowed Date
        /// </summary>
        public DateTime BorrowedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Borrowed Quantity
        /// </summary>
        public int BorrowedQuantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Due Date
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Returned Date
        /// </summary>
        public DateTime ReturnedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Returned Quantity
        /// </summary>
        public int ReturnedQuantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Remarks
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// Model builder to create it own model to declare field and relation.
        /// </summary>
        /// <param name="modelbuilder"></param>
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<BorrowedBook>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

                entity.HasOne(e => e.Book).WithMany(e => e.BorrowedBooks);

                entity.Property(e => e.BorrowedDate);

                entity.Property(e => e.BorrowedQuantity);

                entity.Property(e => e.DueDate);

                entity.Property(e => e.ReturnedDate);

                entity.Property(e => e.ReturnedQuantity);

                entity.Property(e => e.Remarks);

                entity.ToTable("BorrowedBooks");
            });
        }
    }
}
