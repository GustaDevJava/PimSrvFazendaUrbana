using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Pessoa(int id, string nome, string cpf, string cnpj, DateTime dataNascimento, string celular, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Cnpj = cnpj;
            DataNascimento = dataNascimento;
            Celular = celular;
            Email = email;
            Senha = senha;
        }
    }
}