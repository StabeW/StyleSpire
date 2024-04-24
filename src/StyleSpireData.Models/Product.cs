namespace StyleSpireData.Models
{
    using StyleSpireData.Common.Models;

    public class Product : BaseDeletableModel<Product>
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
    }
}
