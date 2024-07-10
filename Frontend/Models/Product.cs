using System;
namespace Frontend.Models
{
	public class Product
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverPath { get; set; }

        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }

        public decimal Price { get; set; }

        public double StarRate { get; set; }
        public DateTime CreatedDate { get; set; }

        public Product()
		{
		}
	}
}

