using PimSrvFazendaUrbana.Data;
using PimSrvFazendaUrbana.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using PimSrvFazendaUrbana.Services.Exception;
using System.Data.Entity.Migrations;

namespace PimSrvFazendaUrbana.Services
{
    public class ClienteService
    {
        private readonly PimSrvFazendaUrbanaContext _context = new PimSrvFazendaUrbanaContext();

        public ClienteService() { }

        public ClienteService(PimSrvFazendaUrbanaContext context)
        {
            _context = context;
        }   

        public Cliente ValidLogin(string email, string senha)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Email == email);

            if (cliente == null) { 
                return null;
            }

            if (cliente.Senha == senha)
            {
                return cliente;
            }

            return null;
        }

        public async Task Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Editar(Cliente cliente)
        {
            bool hasAny = await _context.Clientes.AnyAsync(x => x.Id == cliente.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Clientes.AddOrUpdate(cliente);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}