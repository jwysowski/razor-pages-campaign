#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCampaign.Models;

namespace RazorPagesCampaign.Pages.Campaigns
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCampaignContext _context;

        public IndexModel(RazorPagesCampaignContext context)
        {
            _context = context;
        }

        public IList<Campaign> Campaign { get;set; }

        public async Task OnGetAsync()
        {
            Campaign = await _context.Campaign.ToListAsync();
        }
    }
}
