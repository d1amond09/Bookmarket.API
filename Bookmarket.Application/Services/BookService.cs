using Contracts;
using Contracts.Services;

namespace Application.Services;

public sealed class BookService(IRepositoryManager repository, ILoggerManager logger) : IBookService
{
	private readonly IRepositoryManager _repository = repository;
	private readonly ILoggerManager _logger = logger;
}

