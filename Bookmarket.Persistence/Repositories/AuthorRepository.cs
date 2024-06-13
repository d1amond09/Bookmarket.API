using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmarket.Domain.Models;
using Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookmarket.Persistence.Repositories;

public class AuthorRepository(AppDbContext appDbContext) : 
	RepositoryBase<Author>(appDbContext), IAuthorRepository
{
	public void CreateAuthor(Author author) => Create(author);

	public void DeleteAuthor(Author author) => Delete(author);

	public async Task<IEnumerable<Author>> GetAllAuthorsAsync(bool trackChanges) =>
		await FindAll(trackChanges)
			.OrderBy(c => c.FullName)
			.ToListAsync();
	public async Task<Author?> GetAuthorAsync(Guid companyId, bool trackChanges) =>
		await FindByCondition(c => c.Id.Equals(companyId), trackChanges)
			.SingleOrDefaultAsync();

	public async Task<IEnumerable<Author>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
		await FindByCondition(x => ids.Contains(x.Id), trackChanges)
			.ToListAsync();
}
