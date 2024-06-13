using Bookmarket.Domain.Models;

namespace Contracts.Repositories;

public interface IAuthorRepository
{
	Task<IEnumerable<Author>> GetAllAuthorsAsync(bool trackChanges);
	Task<IEnumerable<Author>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
	Task<Author?> GetAuthorAsync(Guid authorId, bool trackChanges);
	public void CreateAuthor(Author author);
	public void DeleteAuthor(Author author);
}
