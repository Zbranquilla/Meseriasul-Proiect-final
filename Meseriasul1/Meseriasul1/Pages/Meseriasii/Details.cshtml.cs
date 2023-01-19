using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Meseriasul1.Data;
using Meseriasul1.Models;

namespace Meseriasul1.Pages.Meseriasii
{
    public class DetailsModel : PageModel
    {
        private readonly Meseriasul1.Data.Meseriasul1Context _context;

        public DetailsModel(Meseriasul1.Data.Meseriasul1Context context)
        {
            _context = context;
        }

      public Meserias Meserias { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Meserias == null)
            {
                return NotFound();
            }

            var meserias = await _context.Meserias.FirstOrDefaultAsync(m => m.ID == id);
            if (meserias == null)
            {
                return NotFound();
            }
            else 
            {
                Meserias = meserias;
            }
            return Page();
        }
    }
}
