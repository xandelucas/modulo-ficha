﻿using Mfc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mfc.Services
{
    public class CursoService
    {
        public readonly MfcContext _context;

        public CursoService(MfcContext context)
        {
            _context = context;
        }

        
    }
}
