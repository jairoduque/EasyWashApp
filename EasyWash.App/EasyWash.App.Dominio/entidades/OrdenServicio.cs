using System;
namespace EasyWash.App.Dominio
{
    public class OrdenServicio
    {
        public int Id {get;set;}
        public DateTime Fecha_ordser {get; set;}
        public Cliente Cliente {get; set;}
        public Vehiculo Vehiculo {get; set;}
        public Servicio Servicio {get; set;}
        public Trabajador Trabajador {get; set;}
        public int Valor_ordser {get; set;}
        public string Estado_ordser {get; set;}
    }
}