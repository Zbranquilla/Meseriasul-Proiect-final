using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Meseriasul1.Data;
using Meseriasul1.Models;

namespace Meseriasul1.Pages.Meseriasii
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
        ViewData["ServiciuID"] = new SelectList(_context.Servicii, "ID", "NumeServiciu");
         ViewData["ProgramareID"] = new SelectList(_context.Set<Programare>(), "ID", "Dataprogramarii");

            return Page();
        }

        [BindProperty]
        public Meserias Meserias { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meserias.Add(Meserias);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
