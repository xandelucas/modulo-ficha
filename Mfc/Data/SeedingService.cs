using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mfc.Models;

namespace Mfc.Data
{
    public class SeedingService
    {
        private MfcContext _context;

        public SeedingService(MfcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Cursos.Any())
            {
                return; //BD populado
            }

            Cursos c1 = new Cursos(1, "Administração", "Universidade Federal de Mato Grosso, Faculdade de Administração e Ciências Contábeis, Cuiabá,",3);
            Cursos c2 = new Cursos(2, "Ciência da Computação", "Universidade Federal de Mato Grosso, Instituto de Computação, Cuiabá,", 3);
            Cursos c3 = new Cursos(3, "Ciências da Saúde", "Universidade Federal de Mato Grosso, Faculdade de Ciências Médicas, Programa de Pós-Graduação em Ciências da Saúde, Cuiabá,", 1);

            Trabalho t1 = new Trabalho(1, "Tese");
            Trabalho t2 = new Trabalho(2, "Dissertação");
            Trabalho t3 = new Trabalho(3, "TCC (Especialização)");
            Trabalho t4 = new Trabalho(4, "TCC (Graduação)");

            _context.Cursos.AddRange(c1, c2, c3);

            _context.Trabalho.AddRange(t1, t2, t3, t4);

            _context.SaveChanges();

        }

    }
}
