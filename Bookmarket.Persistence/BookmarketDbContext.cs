﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmarket.Domain.Models;
using Bookmarket.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Bookmarket.Persistence;

public class BookmarketDbContext(DbContextOptions options) : DbContext(options)
{
	public DbSet<Publisher>? Publishers { get; set; }
	public DbSet<Author>? Authors { get; set; }
	public DbSet<Book>? Books { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfiguration(new AuthorConfiguration());
		modelBuilder.ApplyConfiguration(new PublisherConfiguration());
		modelBuilder.ApplyConfiguration(new BookConfiguration());

	}

}