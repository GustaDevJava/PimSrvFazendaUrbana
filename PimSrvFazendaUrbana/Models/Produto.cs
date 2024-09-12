using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public double Desconto { get; set; }
        public double Total { get; set; }
        public string Cupom { get; set; }

    }
}