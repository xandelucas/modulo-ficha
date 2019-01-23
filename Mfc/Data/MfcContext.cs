using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mfc.Models
{
    public class MfcContext : DbContext
    {
        public MfcContext (DbContextOptions<MfcContext> options)
            : base(options)
        {
        }

        public DbSet<Mfc.Models.Cursos> Cursos { get; set; }
    }
}
