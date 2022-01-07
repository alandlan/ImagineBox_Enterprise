using IBE.Core.Data;
using IBE.Cliente.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBE.Cliente.API.Data
{
    public class ClienteContext : DbContext, IUnitOfWork
    {
        public ClienteContext(DbContextOptions<ClienteContext> options): base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClienteContext).Assembly);
        }
    }
}
