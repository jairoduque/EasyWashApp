using System;
using System.Collections.Generic;

namespace EasyWash.App.Dominio.entidades
{
    public class Cliente : Persona
    {
        public int Id {get;set;}
        public DateTime FechaIng_cli {get; set;}
        public string Estado_cli {get; set;}

        public Vehiculo Vehiculo {get; set;}
    }
}