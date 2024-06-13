using Bookmarket.Domain.Models;

namespace Contracts.Repositories;

public interface IPublisherRepository
{
	Task<IEnumerable<Publisher>> GetAllPublishersAsync(bool trackChanges);
	Task<IEnumerable<Publisher>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
	Task<Publisher?> GetPublisherAsync(Guid publisherId, bool trackChanges);
	public void CreatePublisher(Publisher publisher);
	public void DeletePublisher(Publisher publisher);
}
