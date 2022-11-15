using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Oroian_Stefania_Lab2_1_.Data;
using Oroian_Stefania_Lab2_1_.Models.ViewModels;

namespace Oroian_Stefania_Lab2_1_.Pages.Borrowings
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
            var bookList = _context.Book
     .Include(b => b.Author)
     .Select(x => new
     {
         x.ID,
         BookFullName = x.Title + " - " + x.Author.AuthorLastName + " " +
    x.Author.AuthorFirstName
     });

            ViewData["BookID"] = new SelectList(bookList, "ID",
           "BookFullName");
            ViewData["MemberID"] = new SelectList(_context.Member, "ID",
           "FullName");
            return Page();
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Borrowing.Add(Borrowing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
