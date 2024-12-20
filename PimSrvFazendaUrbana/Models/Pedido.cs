﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Now;
        public double Desconto { get; set; }
        public double Total { get; set; }
        public string Cupom { get; set; }

        public ICollection<Carrinho> Carrinhos { get; set; } = new List<Carrinho>();
    }
}