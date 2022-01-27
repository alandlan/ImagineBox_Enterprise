using IBE.Core.Messages;
using System;

namespace IBE.Cliente.API.Application.Events
{
    public class ClienteRegistradoEvent : Event
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public ClienteRegistradoEvent(Guid id, string nome, string email, string cpf)
        {
            AggredateId = id;
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
    }
}
