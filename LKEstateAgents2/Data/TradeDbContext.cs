using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LKEstateAgents2.Models;

namespace LKEstateAgents2.Data
{
    public class TradeDbContext : DbContext
    {
        public TradeDbContext (DbContextOptions<TradeDbContext> options)
            : base(options)
        {
        }

        public DbSet<LKEstateAgents2.Models.Trade> Trade { get; set; } = default!;
    }
}
