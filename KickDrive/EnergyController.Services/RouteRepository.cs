using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using System.Linq;


namespace EnergyController.Services
{
    public class RouteRepository : SQLRepository<Routes>, IRouteRepository
    {
        public RouteRepository(AppDBContext context): base(context) { }
        public IEnumerable<Driver> GetDrivers()
        {
            return context.Set<Driver>().AsEnumerable();
        }
        public IEnumerable<Vehicles> GetVehicles()
        {
            return context.Set<Vehicles>().AsEnumerable();
        }
    }

}
