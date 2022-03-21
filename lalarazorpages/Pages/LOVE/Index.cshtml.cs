#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lalarazorpages.Data;

namespace lalarazorpages.Pages.LOVE
{
    public class IndexModel : PageModel
    {
        private readonly lalarazorpages.Data.lalarazorpagesContext _context;

        public IndexModel(lalarazorpages.Data.lalarazorpagesContext context)
        {
            _context = context;
        }

        public IList<Spokenpoetry> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
