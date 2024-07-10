using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Entities
{
	public class Images
	{
		[Key]
        public int Id { get; set; }
		public int ProductId { get; set; }
		public string Path { get; set; }
		public Byte Order { get; set; }

		public Images()
		{
		}
	}
}

