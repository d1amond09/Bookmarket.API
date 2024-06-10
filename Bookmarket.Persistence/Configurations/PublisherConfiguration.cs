using Bookmarket.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookmarket.Persistence.Configurations;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
	public void Configure(EntityTypeBuilder<Publisher> builder)
	{
		builder.HasKey(a => a.Id);
		builder.HasIndex(a => a.Id).IsUnique();
		builder.HasMany(a => a.Books).WithOne(a => a.Publisher);

		builder.HasData
		(
			new Publisher
			{
				Id = new Guid("c9d1c053-49b6-412c-bc78-2d54a9991870"),
				Name = "Neoclassic",
			},
			new Publisher
			{
				Id = new Guid("c9d2c053-49b6-210c-bc78-2d5112291820"),
				Name = "Like Book",
			}
		);
	}
}
