using Contracts;
using Service.Contracts;

namespace Service;

internal sealed class PublisherService(IRepositoryManager repository, ILoggerManager logger) : IPublisherService
{
	private readonly IRepositoryManager _repository = repository;
	private readonly ILoggerManager _logger = logger;
}

