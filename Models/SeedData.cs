using Microsoft.EntityFrameworkCore;

namespace RazorPagesCampaign.Models {
	public static class SeedData {
		public static void Initialize(IServiceProvider serviceProvider) {
			using (var context = new RazorPagesCampaignContext(
				serviceProvider.GetRequiredService<
				DbContextOptions<RazorPagesCampaignContext>>()
			)) {
				if (context == null || context.Campaign == null || context.Keyword == null)
					throw new ArgumentNullException("Null RazorPagesCampaignContext.");

				if (!context.Keyword.Any()) {
					context.Keyword.AddRange(
						new Keyword {
							Name = "software"
						},
						new Keyword {
							Name = "programming"
						},
						new Keyword {
							Name = "data"
						},
						new Keyword {
							Name = "car"
						},
						new Keyword {
							Name = "automotive"
						},
						new Keyword {
							Name = "racing"
						},
						new Keyword {
							Name = "food"
						},
						new Keyword {
							Name = "restaurant"
						},
						new Keyword {
							Name = "fastfood"
						},
						new Keyword {
							Name = "supermarket"
						}
					);
				}

				if (!context.Campaign.Any()) {
					context.Campaign.AddRange(
						new Campaign {
							Name = "Google",
							BidAmount = 1000000,
							Keywords = new List<Keyword> {
								new Keyword {
									Name = "software"
								},
								new Keyword {
									Name = "programming"
								},
								new Keyword {
									Name = "data"
								} 
							},
							Status = true,
							Town = "Menlo Park",
							Radius = 250                    
						},
						new Campaign {
							Name = "Mercedes",
							BidAmount = 2000000,
							Keywords = new List<Keyword> {
								new Keyword {
									Name = "car"
								},
								new Keyword {
									Name = "automotive"
								},
								new Keyword {
									Name = "racing"
								}
							},
							Status = true,
							Town = "Stuttgart",
							Radius = 770                    
						},
						new Campaign {
							Name = "McDonald's",
							BidAmount = 500000,
							Keywords = new List<Keyword> {
								new Keyword {
									Name = "food"
								},
								new Keyword {
									Name = "restaurant"
								},
								new Keyword {
									Name = "fastfood"
								}
							},
							Status = false,
							Town = "Chicago",
							Radius = 770                    
						},
						new Campaign {
							Name = "Tesco",
							BidAmount = 350000,
							Keywords = new List<Keyword> {
								new Keyword {
									Name = "supermarket"
								}
							},
							Status = false,
							Town = "Welwyn Garden City",
							Radius = 100                    
						}
				);
				}

				context.SaveChanges();
			}
		}
	}
}