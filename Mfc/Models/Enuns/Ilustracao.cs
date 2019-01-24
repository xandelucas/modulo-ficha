using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mfc.Models.Enuns
{
    public enum Ilustracao
    {
        [Display(Name = "Não possui")]
        Nenhuma,
        [Display(Name = "Preto e Branco")]
        PretoBranco,
        [Display(Name = "Coloridas")]
        Colorida,
       
    }
}
