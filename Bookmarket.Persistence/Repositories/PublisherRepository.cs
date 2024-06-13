using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using Bookmarket.Domain.Models;
using Bookmarket.Persistence.Repositories;
using Bookmarket.Persistence;

namespace Bookmarket.Persistence.Repositories;

public class PublisherRepository(AppDbContext appDbContext) :
	RepositoryBase<Publisher>(appDbContext), IPublisherRepository
{
	public void CreatePublisher(Publisher publisher)
	{
		Create(publisher);
	}

	public void DeletePublisher(Publisher publisher) => Delete(publisher);

	public async Task<IEnumerable<Publisher>> GetAllPublishersAsync(bool trackChanges) =>
		await FindAll(trackChanges)
			.OrderBy(c => c.Name)
			.ToListAsync();

	public async Task<Publisher?> GetPublisherAsync(Guid id, bool trackChanges) =>
		await FindByCondition(e => e.Id.Equals(id), trackChanges)
				.SingleOrDefaultAsync();

	public async Task<IEnumerable<Publisher>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
		await FindByCondition(x => ids.Contains(x.Id), trackChanges)
			.ToListAsync();
}
