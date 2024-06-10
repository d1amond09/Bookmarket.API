using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookmarket.Domain.Models;
using Contracts.Repositories;

namespace Bookmarket.Persistence.Repositories;

public class PublisherRepository(BookmarketDbContext bookmarketDbContext) : 
	RepositoryBase<Publisher>(bookmarketDbContext), IPublisherRepository
{

}
