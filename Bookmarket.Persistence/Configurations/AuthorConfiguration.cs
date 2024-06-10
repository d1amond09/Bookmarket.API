using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmarket.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Bookmarket.Persistence.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
	public void Configure(EntityTypeBuilder<Author> builder)
	{
		builder.HasKey(a => a.Id);
		builder.HasIndex(a => a.Id).IsUnique();
		builder.HasMany(a => a.Books).WithMany(b => b.Authors);

		builder.HasData
		(
			new Author
			{
				Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
				FullName = "Jack London",
			},
			new Author
			{
				Id = new Guid("c9d4c053-49b6-410c-bc78-2d5112991870"),
				FullName = "Lev Tolstoy",
			}
		);

	}
}
