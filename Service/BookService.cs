using Contracts;
using Service.Contracts;

namespace Service;

internal sealed class BookService(IRepositoryManager repository, ILoggerManager logger) : IBookService
{
	private readonly IRepositoryManager _repository = repository;
	private readonly ILoggerManager _logger = logger;
}

