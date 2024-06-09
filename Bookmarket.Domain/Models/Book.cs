using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookmarket.Domain.Models;

public class Book
{
	[Column("BookId")]
	public Guid Id { get; private set; }

	[Required(ErrorMessage = "Book title is a required field.")]
	[MaxLength(100, ErrorMessage = "Maximum length for the title is 100 characters.")]
	public string Title { get; private set; } = string.Empty;

	[Required(ErrorMessage = "Book Description is a required field.")]
	[MaxLength(500, ErrorMessage = "Maximum length for the description is 500 characters.")]
	public string Description { get; private set; } = string.Empty;
	
	[Required(ErrorMessage = "Book ISBN is a required field.")]
	[MaxLength(17, ErrorMessage = "Maximum length for the ISBN is 17 characters.")]
	[MinLength(17, ErrorMessage = "Minimum length for the ISBN is 17 characters.")]
	public string ISBN { get; private set; } = string.Empty;
	
	[Required(ErrorMessage = "Count of book pages is a required field.")]
	public int PagesCount { get; private set; }

	[Required(ErrorMessage = "Year of publication is a required field.")]
	public int PublicationYear { get; private set; }

	[Required(ErrorMessage = "Book binding is a required field.")]
	[MaxLength(50, ErrorMessage = "Maximum length for the binding is 50 characters.")]
	public string Binding { get; private set; } = string.Empty;

	[ForeignKey(nameof(Publisher))]
	public Guid PublisherId { get; private set; }
	public Publisher Publisher { get; private set; }

	public ICollection<Author> Authors { get; private set; } = [];
}
