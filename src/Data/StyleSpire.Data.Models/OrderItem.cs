﻿namespace StyleSpire.Data.Models
{
    public class OrderItem
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}