using System;
using System.Collections.Generic;

namespace EasyWash.App.Dominio.entidades
{
    public class Cliente : Persona
    {
        public DateTime FechaIng_cli {get; set;}
        public string Estado_cli {get; set;}
    }
}