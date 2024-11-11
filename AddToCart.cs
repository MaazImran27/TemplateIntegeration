namespace Template_Integration.Models
{
	public class AddToCart
	{
		public int Id { get; set; }

		public int ProductId { get; set; }

		public Product Product { get; set; }

		public int quantity { get; set; }
	}
}
