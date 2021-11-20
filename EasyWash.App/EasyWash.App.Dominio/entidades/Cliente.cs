using System;
using System.Collections.Generic;

namespace EasyWash.App.Dominio
{
    public class Cliente : Persona
    {
        public DateTime FechaIng_cli {get; set;}
        public string Usu_cli {get; set;}
        public string Pass_Cli {get; set;}
        public string Estado_cli {get; set;}
        public Vehiculo Vehiculo {get; set;}
    }
}