using Bookmarket.Domain.Models;

namespace Contracts.Repositories;

public interface IBookRepository
{
	Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges);
	Task<IEnumerable<Book>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
	Task<Book?> GetBookAsync(Guid bookId, bool trackChanges);
	public void CreateBook(Guid publisherId, IEnumerable<Guid> authorsIds, Book book);
	public void DeleteBook(Book book);
}
