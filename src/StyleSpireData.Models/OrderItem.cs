namespace StyleSpireData.Models
{
    public class OrderItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}