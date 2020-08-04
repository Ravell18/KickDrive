using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyController.Models
{
    public class Vehicles:BaseEntity
    {
        //Nombre del propietario
        public string NProp { get; set; }
        //Marca
        public string Brand { get; set; }
        //Numero de Serie
        public int NSerie { get; set; }
        //Modelo
        public string Model { get; set; }
        //Tipo de servicio
        public string TipServ { get; set; }
        //Numero de motor
        public int NMotor { get; set; }
        //Tipo de combustible
        public string TComb { get; set; }
        //Documentos legales
        public string DocLeg { get; set; }
        //Tipo de Llantas
        public string TipLlantas { get; set; }
        //Capacidad de personas
        public int CapPerson {get;set;}
        //Capacidad de toneladas
        public int CapTon { get; set; }
        //Placas
        public string Placas { get; set; }
        //Oficina 
        public string OfExp { get; set; }
        //Numero de registro
        public int NRegist { get; set; }

        // Navegabilidad

        public ICollection<Routes> Route { get; set; }
    }
}
