﻿using System.Text.RegularExpressions;

namespace IBE.Core.DomainObjects
{
    public class Email
    {
        public const int EnderecoMaxLength = 254;
        public const int EnderecoMinLength = 5;

        public string Endereco { get; set; }

        protected Email() { }
        public Email(string endereco)
        {
            if (!Validar(endereco)) throw new DomainException("E-mail inválido!");
            Endereco = endereco;
        }

        public static bool Validar(string email)
        {
            var regexEmail = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return regexEmail.IsMatch(email);
        }
    }
}
