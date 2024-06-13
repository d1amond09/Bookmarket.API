using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarket.Domain.Responses;

public sealed class ApiOkResponse<TResult>(TResult result) : ApiBaseResponse(true)
{
	public TResult Result { get; set; } = result;
}
