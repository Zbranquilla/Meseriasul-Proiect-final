using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Meseriasul1.Data;
using Meseriasul1.Models;
using System.Security.Policy;

namespace Meseriasul1.Pages.Servicii
{
    public class CreateModel : PageModel
    {
        private readonly Meseriasul1.Data.Meseriasul1Context _context;

        public CreateModel(Meseriasul1.Data.Meseriasul1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ProgramareID"] = new SelectList(_context.Set<Programare>(), "ID", "Dataprogramarii");
            return Page();
        }

        [BindProperty]
        public Serviciu Serviciu { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Servicii.Add(Serviciu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
