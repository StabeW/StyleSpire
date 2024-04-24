namespace StyleSpireData.Models
{
    using StyleSpireData.Common.Models;

    public class Order : BaseDeletableModel<Order>
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<OrderItem> Products { get; set; } = new HashSet<OrderItem>();

        public decimal TotalPrice { get; set; }
    }
}
