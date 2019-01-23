using Mfc.Models;
using Mfc.Models.Enuns;
using System;
using System.Collections.Generic;


namespace Mfc.Views.ViewModels
{
    public class CursosViewModel
    {
        public Cursos Curso { get; set; }
        public ICollection<Trabalho> Trabalhos { get; set; }
    }
}
