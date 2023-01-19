using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Meseriasul1.Data;
using Meseriasul1.Models;

namespace Meseriasul1.Pages.Servicii
{
    public class DeleteModel : PageModel
    {
        private readonly Meseriasul1.Data.Meseriasul1Context _context;

        public DeleteModel(Meseriasul1.Data.Meseriasul1Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Serviciu Serviciu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Servicii == null)
            {
                return NotFound();
            }

            var serviciu = await _context.Servicii.FirstOrDefaultAsync(m => m.ID == id);

            if (serviciu == null)
            {
                return NotFound();
            }
            else 
            {
                Serviciu = serviciu;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Servicii == null)
            {
                return NotFound();
            }
            var serviciu = await _context.Servicii.FindAsync(id);

            if (serviciu != null)
            {
                Serviciu = serviciu;
                _context.Servicii.Remove(Serviciu);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
