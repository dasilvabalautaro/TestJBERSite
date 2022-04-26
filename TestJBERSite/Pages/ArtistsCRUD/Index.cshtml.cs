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
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly TestJBERSite.Data.TestJBERSiteContext _context;

        public IndexModel(TestJBERSite.Data.TestJBERSiteContext context)
        {
            _context = context;
        }

        public IList<Artist> Artist { get;set; }

        public async Task OnGetAsync()
        {
            Artist = await _context.Artist.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
