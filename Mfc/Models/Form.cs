using Mfc.Models;
using Mfc.Models.Enuns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mfc.Models
{
    public class Form
    {
        public int Id { get; set; }

        
        public string Nome { get; set; }
        [Display(Name = "Título do trabalho:")]
        public string Titulo { get; set; }

        [Display(Name = "Sub-título do trabalho:")]
        public string SubTitulo { get; set; }

        [Display(Name = "Código Cutter:")]
        public CodCutter CodCutter { get; set; }

        public string Trabalho { get; set; } /* (Tese, Dissertação, TCC(Especialização), TCC(Graduação)*/
        public Cursos Curso { get; set; } //Pesquisar como fazer a pesquisa

        [Display(Name = "Nome completo do orientador:")]
        public string NomeOrientador { get; set; }
        public bool Orientadora { get; set; }

        [Display(Name = "Nome completo do coorientador:")]
        public string NomeCoorientador { get; set; }
        public bool Coorientadora { get; set; }
        public int Ano { get; set; }
        public PadraoNumFol TipoFolha { get; set; }
        public int PadraoNumFolId { get; set; }
        public int NumFolhaRomano { get; set; }
        public int NumFolhaArabico { get; set; }
        public Ilustracao TipoIlustracao { get; set; }
        public bool Bibliografia { get; set; }
        public int AlturaFolha { get; set; }
        public string PalavrasChave { get; set; } //Erro por ser list
        public Fonte TipoFonte { get; set; }
        public int TamFonte { get; set; }

       
    }
}
