using IBE.Cliente.API.Application.Commands;
using IBE.Core.Mediator;
using IBE.WebApi.Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IBE.Cliente.API.Controllers
{
    public class ClienteController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClienteController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var result = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Alan", "alan4lann@gmail.com", "31731782039"));

            return CustomResponse(result);
        }
    }
}
