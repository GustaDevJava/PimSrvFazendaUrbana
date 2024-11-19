using PimSrvFazendaUrbana.Data;
using PimSrvFazendaUrbana.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PimSrvFazendaUrbana.Services
{
    public class PedidoService
    {
        private readonly PimSrvFazendaUrbanaContext _context;


        public PedidoService(PimSrvFazendaUrbanaContext context)
        {
            _context = context;
        }

        public async Task<Pedido> CriarPedidoAsync(int clienteId, List<int> produtoIds, double desconto, string cupom)
        {
            var pedido = new Pedido
            {
                ClienteId = clienteId,
                Desconto = desconto,
                Cupom = cupom,
                Total = 0 // Calculado posteriormente
            };

            foreach (var produtoId in produtoIds)
            {
                var produto = await _context.Produtos.FindAsync(produtoId);
                if (produto != null)
                {
                    pedido.Total += produto.Preco;
                    pedido.Carrinhos.Add(new Carrinho { ProdutoId = produtoId });
                }
            }

            pedido.Total -= desconto;
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();

            return pedido;
        }

        public async Task<Pedido> ObterPedidoPorIdAsync(int id)
        {
            return await _context.Pedidos
                .Include(p => p.Carrinhos)
                .FirstOrDefaultAsync(p => p.Id == id); ;
        }
    }
}