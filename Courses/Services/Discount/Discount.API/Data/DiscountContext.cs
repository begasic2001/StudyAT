using Discount.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Data
{
    public class DiscountContext : DbContext
    {
        public DiscountContext(DbContextOptions<DiscountContext> options) : base(options)
        {
           
        }
        public DbSet<Coupon> coupons { get; set; }
    }
}
