using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LKEstateAgents2.Models;

namespace LKEstateAgents2.Data
{
    public class PropertyDbContext : DbContext
    {
        public PropertyDbContext (DbContextOptions<PropertyDbContext> options)
            : base(options)
        {
        }

        public DbSet<LKEstateAgents2.Models.Property> Property { get; set; } = default!;
    }
}
