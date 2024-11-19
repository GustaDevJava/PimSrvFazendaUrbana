using PimSrvFazendaUrbana.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Services
{
    public class CarrinhoService
    {
        private readonly PimSrvFazendaUrbanaContext _context = new PimSrvFazendaUrbanaContext();

        public CarrinhoService() { }
        public CarrinhoService(PimSrvFazendaUrbanaContext context) 
        { 
            _context = context;
        }

       


    }
}