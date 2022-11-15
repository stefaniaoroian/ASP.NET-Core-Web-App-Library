using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Oroian_Stefania_Lab2_1_.Data;
using Oroian_Stefania_Lab2_1_.Models;

namespace Oroian_Stefania_Lab2_1_.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Oroian_Stefania_Lab2_1_.Data.Oroian_Stefania_Lab2_1_Context _context;

        public CreateModel(Oroian_Stefania_Lab2_1_.Data.Oroian_Stefania_Lab2_1_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
