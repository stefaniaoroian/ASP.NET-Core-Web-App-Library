using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Oroian_Stefania_Lab2_1_.Data;
using Oroian_Stefania_Lab2_1_.Models;

namespace Oroian_Stefania_Lab2_1_.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Oroian_Stefania_Lab2_1_.Data.Oroian_Stefania_Lab2_1_Context _context;

        public DetailsModel(Oroian_Stefania_Lab2_1_.Data.Oroian_Stefania_Lab2_1_Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
