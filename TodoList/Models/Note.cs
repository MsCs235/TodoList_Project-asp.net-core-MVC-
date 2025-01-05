using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
	public class Note
	{
		public int Id { get; set; }
		public required string Title { get; set; }
		public string? Content { get; set; }

		[ForeignKey("User")]
		public required int UserID { get; set; }

	}
}
