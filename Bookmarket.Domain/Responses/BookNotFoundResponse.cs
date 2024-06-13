using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarket.Domain.Responses;

public sealed class BookNotFoundResponse(Guid id) 
	: ApiNotFoundResponse($"Book with id: {id} is not found in db.")
{

}

