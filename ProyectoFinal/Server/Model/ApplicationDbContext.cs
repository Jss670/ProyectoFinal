using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Server.Model.Entities;
using System.Collections.Generic;

namespace ProyectoFinal.Server.Model
{
    public class ApplicationDbContext : DbContext

    {

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {


        }
        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<Registros> Registros { get; set; }

        public DbSet<Ventas> Ventas { get; set; }

    }

}
