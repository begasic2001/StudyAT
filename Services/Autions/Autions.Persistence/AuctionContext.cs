using Autions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autions.Persistence
{
    public class AuctionContext : DbContext
    {
        public AuctionContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Auction> Auctions { get; set; }
    }
}
