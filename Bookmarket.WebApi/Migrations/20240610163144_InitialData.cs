using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookmarket.WebApi.Migrations
{
	/// <inheritdoc />
	public partial class InitialData : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
				table: "Authors",
				columns: new[] { "AuthorId", "FullName" },
				values: new object[,]
				{
					{ new Guid("c9d4c053-49b6-410c-bc78-2d5112991870"), "Lev Tolstoy" },
					{ new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Jack London" }
				});

			migrationBuilder.InsertData(
				table: "Publishers",
				columns: new[] { "PublisherId", "Name" },
				values: new object[,]
				{
					{ new Guid("c9d1c053-49b6-412c-bc78-2d54a9991870"), "Neoclassic" },
					{ new Guid("c9d2c053-49b6-210c-bc78-2d5112291820"), "Like Book" }
				});

			migrationBuilder.InsertData(
				table: "Books",
				columns: new[] { "BookId", "Binding", "Description", "ISBN", "PagesCount", "PublicationYear", "PublisherId", "Title" },
				values: new object[,]
				{
					{ new Guid("b1d1c023-49b6-412c-bc78-2d54a9991870"), "Paperback", "Description", "978-5-170-91267-4", 240, 2010, new Guid("c9d2c053-49b6-210c-bc78-2d5112291820"), "White Fang" },
					{ new Guid("c9d2c053-49b6-210c-bc78-225112291bbb"), "Hard cover", "Description", "978-5-389-16226-6", 992, 2019, new Guid("c9d2c053-49b6-210c-bc78-2d5112291820"), "The Call of the Wild" }
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "Authors",
				keyColumn: "AuthorId",
				keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d5112991870"));

			migrationBuilder.DeleteData(
				table: "Authors",
				keyColumn: "AuthorId",
				keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));

			migrationBuilder.DeleteData(
				table: "Books",
				keyColumn: "BookId",
				keyValue: new Guid("b1d1c023-49b6-412c-bc78-2d54a9991870"));

			migrationBuilder.DeleteData(
				table: "Books",
				keyColumn: "BookId",
				keyValue: new Guid("c9d2c053-49b6-210c-bc78-225112291bbb"));

			migrationBuilder.DeleteData(
				table: "Publishers",
				keyColumn: "PublisherId",
				keyValue: new Guid("c9d1c053-49b6-412c-bc78-2d54a9991870"));

			migrationBuilder.DeleteData(
				table: "Publishers",
				keyColumn: "PublisherId",
				keyValue: new Guid("c9d2c053-49b6-210c-bc78-2d5112291820"));
		}
	}
}
