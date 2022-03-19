#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesCampaign.Models;

    public class RazorPagesCampaignContext : DbContext
    {
        public RazorPagesCampaignContext (DbContextOptions<RazorPagesCampaignContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCampaign.Models.Campaign> Campaign { get; set; }
    }
