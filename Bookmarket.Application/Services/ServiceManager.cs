using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Repositories;
using Contracts.Services;

namespace Application.Services;

public class ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger) : IServiceManager
{

	private readonly Lazy<IAuthorService> _authorService = new(() => 
		new	AuthorService(repositoryManager, logger));

	private readonly Lazy<IPublisherService> _publisherService = new(() => 
		new PublisherService(repositoryManager, logger));

	private readonly Lazy<IBookService> _bookService = new(() => 
		new BookService(repositoryManager, logger));

	public IAuthorService AuthorService => _authorService.Value;
	public IPublisherService PublisherService => _publisherService.Value;
	public IBookService BookService => _bookService.Value;
}
