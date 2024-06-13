using Contracts;
using Contracts.Services;

namespace Application.Services;

public sealed class AuthorService(IRepositoryManager repository, ILoggerManager logger) : IAuthorService
{
	private readonly IRepositoryManager _repository = repository;
	private readonly ILoggerManager _logger = logger;
}

