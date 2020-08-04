using EnergyController.Models;
using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Services.Controladores;

namespace EnergyController.Services
{
    public interface IRepositoryLogins
    {
        public int InsertL(User user);
    }
}
