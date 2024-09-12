using PimSrvFazendaUrbana.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Funcionario : Pessoa
    {

        public double Salario { get; set; }
        public Funcao Funcao { get; set; }
        public int FazendaId { get; set; }

        public Funcionario(int id, string nome, string cpf, string cnpj, DateTime dataNascimento, string celular, string email, string senha) : base(id, nome, cpf, cnpj, dataNascimento, celular, email, senha)
        {
        }

    }
}