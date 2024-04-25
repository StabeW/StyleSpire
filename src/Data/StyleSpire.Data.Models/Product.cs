namespace StyleSpire.Data.Models
{
    using StyleSpire.Data.Common.Models;

    public class Product : BaseDeletableModel<Product>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
