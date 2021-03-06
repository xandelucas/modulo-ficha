﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mfc.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Curso:")]
        public string NomeCurso { get; set; }

        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }

        public Trabalho Trabalho { get; set; }

        public int TrabalhoId { get; set; }

        public Curso()
        {

        }

        public Curso(int id, string nomeCurso, string descricao, Trabalho trabalho)
        {
            Id = id;
            NomeCurso = nomeCurso;
            Descricao = descricao;
            Trabalho = trabalho;

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
