namespace StyleSpire.Data.Models
{
    using System.Collections.Generic;

    using StyleSpire.Data.Common.Models;

    public class Order : BaseDeletableModel<Order>
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; } = new HashSet<OrderItem>();

        public decimal TotalPrice { get; set; }
    }
}
