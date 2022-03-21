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
    public class DetailsModel : PageModel
    {
        private readonly lalarazorpages.Data.lalarazorpagesContext _context;

        public DetailsModel(lalarazorpages.Data.lalarazorpagesContext context)
        {
            _context = context;
        }

        public Spokenpoetry Class { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.FirstOrDefaultAsync(m => m.ID == id);

            if (Class == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
