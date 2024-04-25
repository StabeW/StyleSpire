namespace StyleSpire.Data.Models
{
    using System.Collections.Generic;

    using StyleSpire.Data.Common.Models;

    public class Cart : BaseDeletableModel<Cart>
    {
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int OrderItemId { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();

        public decimal TotalPrice { get; set; }
    }
}
