using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models.Dto
{
    public class Login
    {
        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string email { get; set; }
        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string senha { get; set; }
    }
}