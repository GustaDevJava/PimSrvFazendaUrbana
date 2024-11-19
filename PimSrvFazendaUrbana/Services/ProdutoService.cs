using PimSrvFazendaUrbana.Data;
using PimSrvFazendaUrbana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Services
{
    public class ProdutoService
    {
        private readonly PimSrvFazendaUrbanaContext _context = new PimSrvFazendaUrbanaContext();

        public ProdutoService() { }

        public ProdutoService(PimSrvFazendaUrbanaContext context)
        {
            _context = context;
        }

       
    }
}