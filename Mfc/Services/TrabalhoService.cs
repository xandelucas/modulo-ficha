﻿using Mfc.Models;
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
            return  _context.Trabalho.OrderBy(x => x.NomeTrabalho).ToList();
        }

        public void Insert(Cursos obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
