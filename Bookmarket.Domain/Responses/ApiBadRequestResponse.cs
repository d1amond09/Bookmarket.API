using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarket.Domain.Responses;

public abstract class ApiBadRequestResponse(string message) : ApiBaseResponse(false)
{
	public string Message { get; set; } = message;
}

