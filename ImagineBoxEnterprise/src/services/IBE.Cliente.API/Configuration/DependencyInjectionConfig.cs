using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using IBE.Cliente.API.Application.Commands;
using IBE.Cliente.API.Application.Events;
using IBE.Cliente.API.Data;
using IBE.Cliente.API.Data.Repository;
using IBE.Cliente.API.Models;
using IBE.Core.Mediator;

namespace IBE.Cliente.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>(); 

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClienteContext>();
        }
    }
}
