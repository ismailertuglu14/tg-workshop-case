using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CategoryAPI.Entities
{
	public class Category
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string Path { get; set; }
		public string DisplayTitle { get; set; }

		public DateTime CreatedDate { get; set; }

		public bool IsActive { get; set; }

		public Category()
		{
			CreatedDate = DateTime.Now;
			IsActive = true;
		}
	}
}

