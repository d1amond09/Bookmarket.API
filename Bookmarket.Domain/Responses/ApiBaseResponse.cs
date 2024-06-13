using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarket.Domain.Responses;

public abstract class ApiBaseResponse(bool success)
{
	public bool Success { get; set; } = success;
}

