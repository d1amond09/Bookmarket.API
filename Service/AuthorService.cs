using Contracts;
using Service.Contracts;

namespace Service;

internal sealed class AuthorService(IRepositoryManager repository, ILoggerManager logger) : IAuthorService
{
	private readonly IRepositoryManager _repository = repository;
	private readonly ILoggerManager _logger = logger;
}

