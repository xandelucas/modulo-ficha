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

        public Trabalho Trabalho { get; set; }
        public ICollection<Cursos> Curso { get; set; } = new List<Cursos>(); //Pesquisar como fazer a pesquisa

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
        public int AlturaFolha { get; set; } = 30;
        public string PalavrasChave { get; set; } //Erro por ser list
        public Fonte TipoFonte { get; set; }
        public int TamFonte { get; set; }

        public Form()
        {

        }

        public Form(int id, string nome, string titulo, string subTitulo, CodCutter codCutter, 
            Trabalho trabalho, string nomeOrientador, bool orientadora, string nomeCoorientador, 
            bool coorientadora, int ano, PadraoNumFol tipoFolha, int padraoNumFolId, int numFolhaRomano, 
            int numFolhaArabico, Ilustracao tipoIlustracao,bool bibliografia, int alturaFolha, 
            string palavrasChave, Fonte tipoFonte, int tamFonte)
        {
            Id = id;
            Nome = nome;
            Titulo = titulo;
            SubTitulo = subTitulo;
            CodCutter = codCutter;
            Trabalho = trabalho;
            NomeOrientador = nomeOrientador;
            Orientadora = orientadora;
            NomeCoorientador = nomeCoorientador;
            Coorientadora = coorientadora;
            Ano = ano;
            TipoFolha = tipoFolha;
            PadraoNumFolId = padraoNumFolId;
            NumFolhaRomano = numFolhaRomano;
            NumFolhaArabico = numFolhaArabico;
            TipoIlustracao = tipoIlustracao;
            Bibliografia = bibliografia;
            AlturaFolha = alturaFolha;
            PalavrasChave = palavrasChave;
            TipoFonte = tipoFonte;
            TamFonte = tamFonte;
        }

        public void GerarFormulario()
        {

        }
    }
}
