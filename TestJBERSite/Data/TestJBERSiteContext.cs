#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestJBERSite.Models;

namespace TestJBERSite.Data
{
    public class TestJBERSiteContext : DbContext
    {
#pragma warning disable CS8618
        public TestJBERSiteContext (DbContextOptions<TestJBERSiteContext> options)
#pragma warning restore CS8618
            : base(options)
        {
        }

        public DbSet<TestJBERSite.Models.Music> Music { get; set; }

        public DbSet<TestJBERSite.Models.Artist> Artist { get; set; }

        public DbSet<TestJBERSite.Models.Song> Song { get; set; }
    }
}
