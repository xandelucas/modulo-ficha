using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mfc.Models
{
    public class Cursos
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Curso:")]
        public string NomeCurso { get; set; }

        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }

        public int TrabalhoId { get; set; }
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
        /*
        public String RetorarCurso(string nomeCurso, string descricao, Trabalho trabalho)
        {
            string resultado = " ";
            return resultado;
        }*/

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
