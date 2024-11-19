using PimSrvFazendaUrbana.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PimSrvFazendaUrbana.Controllers
{
    public class PedidosController : Controller
    {
        private readonly PedidoService _pedidoService;

        public PedidosController() { }
        public PedidosController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        // GET: Pedidos
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> CriarPedido(int clienteId, List<int> produtoIds, double desconto, string cupom)
        {
            var pedido = await _pedidoService.CriarPedidoAsync(clienteId, produtoIds, desconto, cupom);
            if (pedido != null)
            {
                return RedirectToAction("DetalhesPedido", new { id = pedido.Id });
            }
            return HttpNotFound("Erro ao criar o pedido.");
        }

        public async Task<ActionResult> DetalhesPedido(int id)
        {
            var pedido = await _pedidoService.ObterPedidoPorIdAsync(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }
    }
}