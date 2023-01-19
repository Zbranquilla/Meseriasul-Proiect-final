using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Meseriasul1.Data;
using Meseriasul1.Models;

namespace Meseriasul1.Pages.Programari
{
    public class IndexModel : PageModel
    {
        private readonly Meseriasul1.Data.Meseriasul1Context _context;

        public IndexModel(Meseriasul1.Data.Meseriasul1Context context)
        {
            _context = context;
        }

        public IList<Programare> Programare { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Programare != null)
            {
                Programare = await _context.Programare.ToListAsync();
            }
        }
    }
}
