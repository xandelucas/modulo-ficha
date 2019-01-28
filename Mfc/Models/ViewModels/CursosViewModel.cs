using Mfc.Models;
using System;
using System.Collections.Generic;


namespace Mfc.Models.ViewModels
{
    public class CursosViewModel
    {
        public Curso Curso { get; set; }
        public ICollection<Trabalho> Trabalhos { get; set; }

    }
}
