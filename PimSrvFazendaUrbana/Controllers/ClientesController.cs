using PimSrvFazendaUrbana.Models;
using PimSrvFazendaUrbana.Models.Dto;
using PimSrvFazendaUrbana.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PimSrvFazendaUrbana.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClienteService _clienteService;

        public ClientesController()
        {
            _clienteService = new ClienteService();
        }
        // GET: Clientes
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
            var cliente = _clienteService.ValidLogin(login.email, login.senha);

            if (cliente != null)
            {
                Session["ClienteNome"] = cliente.Nome;
                return RedirectToAction(nameof(Logado));
            }
            else
            {
                ModelState.AddModelError("LoginError", "Email ou senha incorretos.");
            }
            return View();
        }

        public ActionResult Logado()
        {
            return RedirectToAction("Index", "Produtos");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction(nameof(Login));
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Cadastrar(Cliente cliente)
        {
            await _clienteService.Cadastrar(cliente);
            TempData["Mensagem"] = "Dados gravados com sucesso";
            return RedirectToAction(nameof(Login));
        }

    }
}