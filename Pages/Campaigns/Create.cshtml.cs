#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesCampaign.Models;

namespace RazorPagesCampaign.Pages.Campaigns
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesCampaignContext _context;

        public CreateModel(RazorPagesCampaignContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Campaign Campaign { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Campaign.Add(Campaign);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
