using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Meseriasul1.Models;

namespace Meseriasul1.Data
{
    public class Meseriasul1Context : DbContext
    {
        public Meseriasul1Context (DbContextOptions<Meseriasul1Context> options)
            : base(options)
        {
        }

        public DbSet<Meseriasul1.Models.Serviciu> Servicii { get; set; } = default!;

        public DbSet<Meseriasul1.Models.Programare> Programare { get; set; }

        public DbSet<Meseriasul1.Models.Meserias> Meserias { get; set; }
    }
}
