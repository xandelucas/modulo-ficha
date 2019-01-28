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
            if (_context.Curso.Any() || _context.Trabalho.Any())
            {
                return; //BD populado
            }
            Trabalho t1 = new Trabalho(1, "Tese");
            Trabalho t2 = new Trabalho(2, "Dissertação");
            Trabalho t3 = new Trabalho(3, "TCC (Especialização)");
            Trabalho t4 = new Trabalho(4, "TCC (Graduação)");

            Curso c1 = new Curso(1, "Administração", "Universidade Federal de Mato Grosso, Faculdade de Administração e Ciências Contábeis, Cuiabá,",t3);
            Curso c2 = new Curso(2, "Ciência da Computação", "Universidade Federal de Mato Grosso, Instituto de Computação, Cuiabá,",t3);
            Curso c3 = new Curso(3, "Ciências da Saúde", "Universidade Federal de Mato Grosso, Faculdade de Ciências Médicas, Programa de Pós-Graduação em Ciências da Saúde, Cuiabá,",t1);


            _context.Trabalho.AddRange(t1, t2, t3, t4);

            _context.Curso.AddRange(c1, c2, c3);

            

            _context.SaveChanges();

        }

    }
}
