using Mfc.Models;
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

        public List<Trabalho> FindAll()
        {
            return  _context.Trabalho.OrderBy(name => name.NomeTrabalho).ToList();
        }
    }
}
