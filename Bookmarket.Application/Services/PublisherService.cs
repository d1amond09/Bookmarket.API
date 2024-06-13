using Contracts;
using Contracts.Services;

namespace Application.Services;

public sealed class PublisherService(IRepositoryManager repository, ILoggerManager logger) : IPublisherService
{
	private readonly IRepositoryManager _repository = repository;
	private readonly ILoggerManager _logger = logger;
}

