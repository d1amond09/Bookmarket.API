using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookmarket.Domain.Models;

public class Book
{
	[Column("BookId")]
	public Guid Id { get; set; }

	[Required(ErrorMessage = "Book title is a required field.")]
	[MaxLength(100, ErrorMessage = "Maximum length for the title is 100 characters.")]
	public string? Title { get; set; } 

	[Required(ErrorMessage = "Book Description is a required field.")]
	[MaxLength(500, ErrorMessage = "Maximum length for the description is 500 characters.")]
	public string? Description { get; set; } 
	
	[Required(ErrorMessage = "Book ISBN is a required field.")]
	[MaxLength(17, ErrorMessage = "Maximum length for the ISBN is 17 characters.")]
	[MinLength(17, ErrorMessage = "Minimum length for the ISBN is 17 characters.")]
	public string? ISBN { get; set; }
	
	[Required(ErrorMessage = "Count of book pages is a required field.")]
	public int PagesCount { get; set; }

	[Required(ErrorMessage = "Year of publication is a required field.")]
	public int PublicationYear { get; set; }

	[Required(ErrorMessage = "Book binding is a required field.")]
	[MaxLength(50, ErrorMessage = "Maximum length for the binding is 50 characters.")]
	public string? Binding { get; set; }

	[ForeignKey(nameof(Publisher))]
	public Guid PublisherId { get; set; }
	public Publisher? Publisher { get; set; }

	public ICollection<Author>? Authors { get; set; }
}
