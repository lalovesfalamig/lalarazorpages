#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lalarazorpages.Pages.LOVE;

namespace lalarazorpages.Data
{
    public class lalarazorpagesContext : DbContext
    {
        public lalarazorpagesContext (DbContextOptions<lalarazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<lalarazorpages.Pages.LOVE.Spokenpoetry> Class { get; set; }
    }
}
