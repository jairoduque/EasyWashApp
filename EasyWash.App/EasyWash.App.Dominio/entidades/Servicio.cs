using System;
namespace EasyWash.App.Dominio

{
    public class Servicio
    {
        public int Id {get; set;}
        public string Nombre_ser {get; set;}
        public string descripcion_ser {get; set;}
        public int Tarifa {get; set;}
        public string Estado {get; set;}
        public TipoVehiculo TipoVehiculo {get; set;}
    }
}