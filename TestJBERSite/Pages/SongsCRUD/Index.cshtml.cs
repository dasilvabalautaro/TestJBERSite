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

namespace TestJBERSite.Pages.SongsCRUD
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly TestJBERSite.Data.TestJBERSiteContext _context;
        private readonly ILogger _logger;
        public string Message { get; set; }

        public IndexModel(TestJBERSite.Data.TestJBERSiteContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; }

        public async Task OnGetAsync()
        {
            Song = await _context.Song.ToListAsync();
            Message = $"List load at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
