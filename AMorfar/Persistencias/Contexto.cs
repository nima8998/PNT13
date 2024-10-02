using AMorfar.Negocios.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Persistencias
{
    public class Contexto:DbContext
    {
        private const string ServerName = "DESKTOP-BSH8LIC";
        private const string InitialCatalog = "AMorfar";

        public DbSet<Persona> Personas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source = {ServerName}; Initial Catalog = {InitialCatalog}; Encrypt = true; TrustServerCertificate = true;  Integrated Security = true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
