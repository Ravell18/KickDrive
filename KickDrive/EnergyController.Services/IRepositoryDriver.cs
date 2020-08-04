using EnergyController.Models;
using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Services.Controladores;

namespace EnergyController.Services
{
    public interface IRepositoryDriver
    {
        public int InsertD(Driver driver);
        public IEnumerable<Driver> GetAll();
        public Driver GetD(int id);
        public IEnumerable<Driver> GetDriver();
        public Driver Updates(Driver driver);
        public Driver Deletes(Driver driver);
    }
}
