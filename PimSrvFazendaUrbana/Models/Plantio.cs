using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Plantio
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public int FazendaId { get; set; }
        public int Status { get; set; }
        public DateTime DataPlantao { get; set; }
        public DateTime DataColheita { get; set; }
    }
}