using Microsoft.EntityFrameworkCore;
using EasyWash.App.Dominio;

namespace EasyWash.App.Persistencia
{
    public class AppContext : DbContext
    {
        public dbSet<Cliente> Clientes {get; set;}
        public dbSet<OrdenServicio> OrdenServicios {get; set;}
        public dbSet<Persona> Personas {get; set;}
        public dbSet<Servicio> Servicios {get; set;}
        public dbSet<TipoVehiculo> TipoVehiculos {get; set;}
        public dbSet<Trabajador> Trabajadores {get; set;}
        public dbSet<Vehiculo> Vehiculos {get; set;}
    }
}