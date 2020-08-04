using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyController.Models
{
    public class Driver:BaseEntity
    {
        public string DriverName { get; set; }
        public string INE { get; set; }
        public string License { get; set; }
        public string NSS { get; set; }
        public string FrontPhoto { get; set; }
        public string ProfilePhoto { get; set; }

        //Navegabilidad
        public ICollection<Routes> Route { get; set; }
    }
}
