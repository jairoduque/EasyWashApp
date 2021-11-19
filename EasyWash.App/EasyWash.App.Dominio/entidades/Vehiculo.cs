namespace EasyWash.App.Dominio
{
    public class Vehiculo : TipoVehiculo
    {
        public int Id {get; set;}
        public string Marca_veh {get; set;}
        public int Modelo_veh {get; set;}
        public string Estado_veh {get; set;}
    }
}