using PimSrvFazendaUrbana.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimSrvFazendaUrbana.Controllers
{
    public class HomeController : Controller
    {

        private readonly ProdutoService _produtoService;

        public HomeController() { 
            _produtoService = new ProdutoService();
        }

        public ActionResult Index()
        {
            
            return RedirectToAction("Index", "Produtos");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}