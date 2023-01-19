using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Meseriasul1.Data;
using Meseriasul1.Models;
using System.Security.Policy;

namespace Meseriasul1.Pages.Servicii
{
    public class EditModel : PageModel
    {
        private readonly Meseriasul1.Data.Meseriasul1Context _context;

        public EditModel(Meseriasul1.Data.Meseriasul1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Serviciu Serviciu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Servicii == null)
            {
                return NotFound();
            }

            var serviciu =  await _context.Servicii.FirstOrDefaultAsync(m => m.ID == id);
            if (serviciu == null)
            {
                return NotFound();
            }
            Serviciu = serviciu;
            ViewData["ProgramareID"] = new SelectList(_context.Set<Programare>(), "ID", "Dataprogramarii");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Serviciu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiciuExists(Serviciu.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ServiciuExists(int id)
        {
          return _context.Servicii.Any(e => e.ID == id);
        }
    }
}
