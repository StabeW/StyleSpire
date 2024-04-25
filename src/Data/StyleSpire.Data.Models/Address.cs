namespace StyleSpire.Data.Models
{
    using StyleSpire.Data.Common.Models;

    public class Address : BaseDeletableModel<Address>
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string Country { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }

        public int PostCode { get; set; }
    }
}
