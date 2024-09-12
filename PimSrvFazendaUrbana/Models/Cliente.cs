using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Cliente : Pessoa
    {
        public Cliente(int id, string nome, string cpf, string cnpj, DateTime dataNascimento, string celular, string email, string senha) : base(id, nome, cpf, cnpj, dataNascimento, celular, email, senha)
        {
        }

        public bool Premium { get; set; }

    }
}