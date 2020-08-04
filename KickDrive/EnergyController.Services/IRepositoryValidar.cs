using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using EnergyController.Services.Controladores;

namespace EnergyController.Services
{
    public interface IRepositoryValidar
    {
        public int Validar(User user);
    }
}
