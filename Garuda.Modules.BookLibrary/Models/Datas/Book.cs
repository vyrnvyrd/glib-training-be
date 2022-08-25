// <copyright file="Book.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Abstract.Contracts;
using Garuda.Database.Framework;
using Garuda.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Garuda.Modules.BookLibrary.Models.Datas
{
    public class Book : BaseModel, IEntity, IEntityRegister
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Cover
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Synopsis
        /// </summary>
        public string Synopsis { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Released Date
        /// </summary>
        public DateTime ReleasedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Genre
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Total Pages
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Stock
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets for Borrowed Book
        /// </summary>
        public IList<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();

        /// <summary>
        /// Model builder to create it own model to declare field and relation.
        /// </summary>
        /// <param name="modelbuilder"></param>
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                .HasMaxLength(100);

                entity.Property(e => e.Author)
                .HasMaxLength(100);

                entity.Property(e => e.Cover);

                entity.Property(e => e.Synopsis)
                .HasMaxLength(1000);

                entity.Property(e => e.ReleasedDate);

                entity.Property(e => e.Genre);

                entity.Property(e => e.TotalPages);

                entity.Property(e => e.Stock);

                entity.ToTable("Books");
            });
        }
    }
}
