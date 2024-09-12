using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Cartao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int Cvv { get; set; }
        public string Apelido { get; set; }
    }
}