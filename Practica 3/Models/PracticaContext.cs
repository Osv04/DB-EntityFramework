using Microsoft.EntityFrameworkCore;
using Practica_3.Models;

namespace Practica_3.Models
{
    public class PracticaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<DescripcionVehiculo> DescripcionesVehiculos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Personal> Personales { get; set; }
        public DbSet<Placa> Placas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Status> Statuses { get; set; }



        public PracticaContext(DbContextOptions<PracticaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Practica_3.Models.FacturaH> FacturaH { get; set; }

    }
}