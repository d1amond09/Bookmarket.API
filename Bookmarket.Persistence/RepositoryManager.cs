using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmarket.Persistence.Repositories;
using Contracts;
using Contracts.Repositories;

namespace Bookmarket.Persistence;

public class RepositoryManager : IRepositoryManager
{
	private readonly AppDbContext _dbContext;
	private readonly Lazy<IAuthorRepository> _authorRepository;
	private readonly Lazy<IPublisherRepository> _publisherRepository;
	private readonly Lazy<IBookRepository> _bookRepository;
	public RepositoryManager(AppDbContext dbContext)
	{
		_dbContext = dbContext;
		_authorRepository = new Lazy<IAuthorRepository>(() => new
			AuthorRepository(_dbContext));
		_publisherRepository = new Lazy<IPublisherRepository>(() => new
			PublisherRepository(_dbContext));
		_bookRepository = new Lazy<IBookRepository>(() => new
			BookRepository(_dbContext));
	}

	public IAuthorRepository Author => _authorRepository.Value;
	public IPublisherRepository Publisher => _publisherRepository.Value;
	public IBookRepository Book => _bookRepository.Value;
	public async Task SaveAsync() => await _dbContext.SaveChangesAsync();
}

