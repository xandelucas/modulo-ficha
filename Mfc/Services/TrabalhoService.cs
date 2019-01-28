using Mfc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mfc.Services
{
    public class TrabalhoService
    {
        public readonly MfcContext _context;

        public TrabalhoService(MfcContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Trabalho>> FindAllSync()
        {
            return await _context.Trabalho.OrderBy(x => x.NomeTrabalho).ToListAsync();
        }

    }
}
