using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Repositories;

namespace Contracts;

public interface IRepositoryManager
{
	IAuthorRepository Author { get; }
	IPublisherRepository Publisher { get; }
	IBookRepository Book { get; }
	Task SaveAsync();
}
