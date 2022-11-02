using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Oroian_Stefania_Lab2_1_.Data;
using Oroian_Stefania_Lab2_1_.Models;

namespace Oroian_Stefania_Lab2_1_.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Oroian_Stefania_Lab2_1_.Data.Oroian_Stefania_Lab2_1_Context _context;

        public IndexModel(Oroian_Stefania_Lab2_1_.Data.Oroian_Stefania_Lab2_1_Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
