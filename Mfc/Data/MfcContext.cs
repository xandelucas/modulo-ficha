using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mfc.Models;

namespace Mfc.Models
{
    public class MfcContext : DbContext
    {
        public MfcContext (DbContextOptions<MfcContext> options)
            : base(options)
        {
        }

        public DbSet<Mfc.Models.Curso> Curso { get; set; }

        public DbSet<Mfc.Models.Trabalho> Trabalho { get; set; }

    }
}
