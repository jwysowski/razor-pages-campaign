using Microsoft.EntityFrameworkCore;

namespace RazorPagesCampaign.Models {
    public static class SeedData {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new RazorPagesCampaignContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesCampaignContext>>()
            )) {
                if (context == null || context.Campaign == null)
                    throw new ArgumentNullException("Null RazorPagesCampaignContext.");

                if (context.Campaign.Any())
                    return;

                context.Campaign.AddRange(
                    new Campaign {
                        Name = "Google",
                        BidAmount = 1000000,
                        Status = true,
                        Town = "Menlo Park",
                        Radius = 250                    
                    },
                    new Campaign {
                        Name = "Mercedes",
                        BidAmount = 2000000,
                        Status = true,
                        Town = "Stuttgart",
                        Radius = 770                    
                    },
                    new Campaign {
                        Name = "McDonald's",
                        BidAmount = 500000,
                        Status = false,
                        Town = "Chicago",
                        Radius = 770                    
                    },
                    new Campaign {
                        Name = "Tesco",
                        BidAmount = 350000,
                        Status = false,
                        Town = "Welwyn Garden City",
                        Radius = 100                    
                    }
                );

                context.SaveChanges();
            }
        }
    }
}