using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarket.Domain.Models;

public class Author
{
	[Column("AuthorId")]
	public Guid Id { get; set; }

	[Required(ErrorMessage = "Author full name is a required field.")]
	[MaxLength(100, ErrorMessage = "Maximum length for the full name is 100 characters.")]
	public string? FullName { get; set; }
	public ICollection<Book>? Books { get; set; }
}
