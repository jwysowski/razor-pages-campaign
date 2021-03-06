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
	public class DeleteModel : PageModel
	{
		private readonly RazorPagesCampaignContext _context;

		public DeleteModel(RazorPagesCampaignContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Campaign Campaign { get; set; }

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Campaign = await _context.Campaign.FirstOrDefaultAsync(m => m.Id == id);

			if (Campaign == null)
			{
				return NotFound();
			}
			return Page();
		}

		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Campaign = await _context.Campaign.FindAsync(id);

			if (Campaign != null)
			{
				_context.Campaign.Remove(Campaign);
				await _context.SaveChangesAsync();
			}

			return RedirectToPage("./Index");
		}
	}
}
