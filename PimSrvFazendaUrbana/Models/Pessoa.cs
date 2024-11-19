using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PimSrvFazendaUrbana.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string Nome { get; set; }

        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "Data é obrigatorio")]
        public DateTime DataNascimento { get; set; }
        public string Celular { get; set; }
        [Required(ErrorMessage = "{0} é obrigatorio")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress (ErrorMessage = "O Email não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string Senha { get; set; }

        public Pessoa(string nome, string cpf, string cnpj, DateTime dataNascimento, string celular, string email, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Cnpj = cnpj;
            DataNascimento = dataNascimento;
            Celular = celular;
            Email = email;
            Senha = senha;
        }

        public Pessoa() { }
    }
}