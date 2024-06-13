using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Bookmarket.Domain.Models;
using Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookmarket.Persistence.Repositories;

public class BookRepository(AppDbContext appDbContext) :
	RepositoryBase<Book>(appDbContext), IBookRepository
{
	public void CreateBook(Guid publisherId, IEnumerable<Guid> authorsIds, Book book)
	{
		book.PublisherId = publisherId;
		Create(book);
	}

	public void DeleteBook(Book book) => Delete(book);

	public async Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges) => 
		await FindAll(trackChanges)
			.OrderBy(c => c.Title)
			.ToListAsync();

	public async Task<Book?> GetBookAsync(Guid id, bool trackChanges) =>
		await FindByCondition(e => e.Id.Equals(id), trackChanges)
				.SingleOrDefaultAsync();

	public async Task<IEnumerable<Book>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
		await FindByCondition(x => ids.Contains(x.Id), trackChanges)
			.ToListAsync();
}
