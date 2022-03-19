#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesCampaign.Models;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.ChangeTracking;

    public class RazorPagesCampaignContext : DbContext
    {
        public RazorPagesCampaignContext (DbContextOptions<RazorPagesCampaignContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCampaign.Models.Campaign> Campaign { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Campaign>()
                    .Property(e => e.Keywords)
                    .HasConversion(
                        v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                        v => JsonSerializer.Deserialize<List<Keyword>>(v, (JsonSerializerOptions)null),
                        new ValueComparer<List<Keyword>>(
                            (c1, c2) => c1.SequenceEqual(c2),
                            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                            c => c.ToList()
                        )
                    );
        }
        public DbSet<RazorPagesCampaign.Models.Keyword> Keyword { get; set; }
    }
