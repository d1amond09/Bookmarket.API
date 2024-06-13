using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Services;

namespace Contracts;

public interface IServiceManager
{
    IAuthorService AuthorService { get; }
    IBookService BookService { get; }
    IPublisherService PublisherService { get; }
}
