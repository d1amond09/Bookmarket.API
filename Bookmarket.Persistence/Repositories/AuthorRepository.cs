using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmarket.Domain.Models;
using Contracts.Repositories;

namespace Bookmarket.Persistence.Repositories;

public class AuthorRepository(BookmarketDbContext bookmarketDbContext) : 
	RepositoryBase<Author>(bookmarketDbContext), IAuthorRepository
{

}
