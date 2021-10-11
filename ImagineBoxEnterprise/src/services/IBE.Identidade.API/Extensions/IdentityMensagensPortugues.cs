using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBE.Identidade.API.Extensions
{
    public class IdentityMensagensPortugues : IdentityErrorDescriber
    {
        public override IdentityError DefaultError()
        {
            return new IdentityError { Code = nameof(DefaultError), Description = $"Ocorreu um erro desconhecido." };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError { Code = nameof(PasswordMismatch), Description = $"Senha incorreta." };
        }
    }
}
