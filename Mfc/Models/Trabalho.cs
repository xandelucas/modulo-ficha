using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mfc.Models
{
    public class Trabalho
    {
        public int Id { get; set; }

        [Display(Name ="Tipo do trabalho")]
        public string NomeTrabalho { get; set; }



        public Trabalho()
        {

        }

        public Trabalho(int id, string nomeTrabalho)
        {
            Id = id;
            NomeTrabalho = nomeTrabalho;
        }
    }
}
