#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestJBERSite.Data;
using TestJBERSite.Models;

namespace TestJBERSite.Pages.ArtistsCRUD
{
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
    public class DeleteModel : PageModel
    {
        private readonly TestJBERSite.Data.TestJBERSiteContext _context;

        public DeleteModel(TestJBERSite.Data.TestJBERSiteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Artist Artist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artist = await _context.Artist.FirstOrDefaultAsync(m => m.ID == id);

            if (Artist == null)
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

            Artist = await _context.Artist.FindAsync(id);

            if (Artist != null)
            {
                _context.Artist.Remove(Artist);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8602
#pragma warning restore CS8604
}
