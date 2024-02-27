namespace Discount.API.Entities
{
    public class Coupon
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
