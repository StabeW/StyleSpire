namespace StyleSpire.Data.Models
{
    using System.Collections.Generic;

    using StyleSpire.Data.Common.Models;

    public class Category : BaseDeletableModel<Category>
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Category> Categories { get; set; } = new HashSet<Category>();

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
