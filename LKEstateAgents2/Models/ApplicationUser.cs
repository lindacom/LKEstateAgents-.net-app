﻿﻿using Microsoft.AspNetCore.Identity;

namespace LKEstateAgents2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}