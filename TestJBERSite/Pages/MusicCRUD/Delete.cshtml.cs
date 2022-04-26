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

namespace TestJBERSite.Pages.MusicCRUD
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
        public Music Music { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Music = await _context.Music.FirstOrDefaultAsync(m => m.ID == id);

            if (Music == null)
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

            Music = await _context.Music.FindAsync(id);

            if (Music != null)
            {
                _context.Music.Remove(Music);
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
