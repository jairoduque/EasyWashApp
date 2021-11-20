using Microsoft.EntityFrameworkCore;
using EasyWash.App.Dominio;

namespace EasyWash.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<OrdenServicio> OrdenServicios {get; set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Servicio> Servicios {get; set;}
        public DbSet<TipoVehiculo> TipoVehiculos {get; set;}
        public DbSet<Trabajador> Trabajadores {get; set;}
        public DbSet<Vehiculo> Vehiculos {get; set;}

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Initial Catalog=Lavadero.NetCore; Data Source=DESKTOP-4AA1456; Integrated Security=true ");
                /* Initial Catalog: Nombre de la base de datos
                Data Source: NOmbre del Servidor de la Base de Datos
                Integrated Security: seguridad con la misma configuracion del inicio
                */
            
            }
        }
    }
}