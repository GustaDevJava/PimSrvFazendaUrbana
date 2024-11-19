using PimSrvFazendaUrbana.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }
        public double Desconto { get; set; }
        public string Image { get; set; }
        public int Quantidade { get; set; }
    }
}