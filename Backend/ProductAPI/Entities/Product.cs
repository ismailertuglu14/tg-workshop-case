using System.ComponentModel.DataAnnotations;
using ProductAPI.Models;

namespace ProductAPI.Entities
{
	public class Product
	{
        [Key]
        public int Id { get; set; }
		public string? Title { get; set; }
		public string? CoverPath { get; set; }

		public int? CategoryId { get; set; }
		public string? CategoryTitle { get; set; }

		public decimal? Price { get; set; }

		public double? StarRate { get; set; }
		public DateTime? CreatedDate { get; set; }
		public ProductStatus? Status { get; set; }

		public ICollection<Images>? Images { get; set; }
		public Product()
		{
			Price = 0.0m;
			StarRate = 0.0;
			CreatedDate = DateTime.Now;
			Status = ProductStatus.PENDING;
		}
	}

}

