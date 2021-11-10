using System;
namespace EasyWash.App.Dominio
{
    public class Persona
    {
        public int id_per {get; set;}
       //Tipo de Documentos
       public TipoDocumento TipoDocumento {get; set;}
        public string numdoc_per {get; set;}
        public string nom_per {get; set;}
        public DateTime fechanac_per {get; set;}
        public int edad_per {get; set;}
        public string tel1_per {get; set;}
        public string tel2_per {get; set;}
        public string dir_per {get; set;}
        public string email_per {get; set;}


    }
}