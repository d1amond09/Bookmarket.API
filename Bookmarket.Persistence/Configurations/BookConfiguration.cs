using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmarket.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookmarket.Persistence.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
	public void Configure(EntityTypeBuilder<Book> builder)
	{
		builder.HasKey(a => a.Id);
		builder.HasIndex(a => a.Id).IsUnique();
		builder.HasMany(a => a.Authors).WithMany(b => b.Books);

		builder.HasData
		(
			new Book
			{
				Id = new Guid("b1d1c023-49b6-412c-bc78-2d54a9991870"),
				Title = "White Fang",
				Description = "Description",
				Binding = "Paperback",
				ISBN = "978-5-170-91267-4",
				PagesCount = 240,
				PublicationYear = 2010,
				PublisherId = new Guid("c9d2c053-49b6-210c-bc78-2d5112291820"),
			},
			new Book
			{
				Id = new Guid("c9d2c053-49b6-210c-bc78-225112291bbb"),
				Title = "The Call of the Wild",
				Description = "Description",
				Binding = "Hard cover",
				ISBN = "978-5-389-16226-6",
				PagesCount = 992,
				PublicationYear = 2019,
				PublisherId = new Guid("c9d2c053-49b6-210c-bc78-2d5112291820"),
			}
		);
	}
}
