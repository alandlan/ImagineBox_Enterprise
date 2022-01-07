﻿using IBE.Core.DomainObjects;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBE.Cliente.API.Models
{
    public class Cliente : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public bool Excluido { get; set; }
        public Endereco Endereco { get; set; }

        // EF Relation
        protected Cliente() { }

        public Cliente(string nome,string email,string cpf)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Excluido = false;
        }
    }
}