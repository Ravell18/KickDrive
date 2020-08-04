using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using EnergyController.Services.Controladores;

namespace EnergyController.Services
{
    public interface IRepositoryVehicles
    {
        public int InsertS(Vehicles vehicles);
        public IEnumerable<Vehicles> GetAll();
        public Vehicles GetVehicles(int id);
        public IEnumerable<Vehicles> GetV();
        public Vehicles Updates(Vehicles vehicles);
        public Vehicles Deletes(Vehicles vehicles);
    }
}
