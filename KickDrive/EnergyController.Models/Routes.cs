using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyController.Models
{
    public class Routes:BaseEntity
    {

        public string NameSup { get; set; }
        public string Ruta { get; set; }
        
        //Incidentes
        public string Incidents { get; set; }
        //Hora de Entrada
        [Required(ErrorMessage = "Check in time is required")]
        public string timeE { get; set; }
        //Hora de Salida
        [Required(ErrorMessage = "Departure time is required")]
        public string timeS { get; set; }
        //Niños y Estudiantes
        public string NYES { get; set; }
        //Adultos
        public string Adults { get; set; }

        //Referencias
        //Driver
        [Display(Name = "Driver")]
        [Required(ErrorMessage = "Driver is required.")]
        [ForeignKey("Driver")]
        public int? DriverId { get; set; }
        public Driver Driver { get; set; }
        //Vehicles
        [Display(Name = "Vehicles")]
        [Required(ErrorMessage = "Vehicles is required.")]
        [ForeignKey("Vehicles")]
        public int? IdVehicles { get; set; }
        public Vehicles Vehicles { get; set; }


        public ICollection<ReportRoute> ReportRoutes { get; set; }

    }
}
