using PimSrvFazendaUrbana.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace PimSrvFazendaUrbana.Data
{
    public class PimSrvFazendaUrbanaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PimSrvFazendaUrbanaContext() : base("name=PimSrvFazendaUrbanaContext")
        {
        }

        public System.Data.Entity.DbSet<PimSrvFazendaUrbana.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<PimSrvFazendaUrbana.Models.Produto> Produtos { get; set; }

        public System.Data.Entity.DbSet<PimSrvFazendaUrbana.Models.Carrinho> Carrinhos { get; set; }

        public System.Data.Entity.DbSet<PimSrvFazendaUrbana.Models.Pedido> Pedidos { get; set; }

       
    }
}
