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

namespace Meseriasul1.Pages.Meseriasii
{
    public class EditModel : PageModel
    {
        private readonly Meseriasul1.Data.Meseriasul1Context _context;

        public EditModel(Meseriasul1.Data.Meseriasul1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Meserias Meserias { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Meserias == null)
            {
                return NotFound();
            }

            var meserias =  await _context.Meserias.FirstOrDefaultAsync(m => m.ID == id);
            if (meserias == null)
            {
                return NotFound();
            }
            Meserias = meserias;
           ViewData["ServiciuID"] = new SelectList(_context.Servicii, "ID", "NumeServiciu");
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

            _context.Attach(Meserias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeseriasExists(Meserias.ID))
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

        private bool MeseriasExists(int id)
        {
          return _context.Meserias.Any(e => e.ID == id);
        }
    }
}
