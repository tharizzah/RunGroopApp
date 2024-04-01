using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RunGroopApp.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;

		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }

		public string Genre { get; set; } = string.Empty;

		[Column(TypeName = "Decimal(18, 2)")]
        public decimal Price { get; set; }

        public string? Rating { get; set; }
    }
}

