using Mfc.Models.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mfc.Models
{
    public class Cursos
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string Descricao { get; set; }
        public Trabalho Trabalho { get; set; }

        public Cursos()
        {

        }

        public Cursos(int id, string nomeCurso, string descricao)
        {
            Id = id;
            NomeCurso = nomeCurso;
            Descricao = descricao;
        }
    }
}
