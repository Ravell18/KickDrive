using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EnergyController.Services.Controladores
{
    public class ContRoutes : SQLRepository<Routes>, IRepositoryRoute
    {
        public ContRoutes(AppDBContext context) : base(context) { }
        public int InsertR(Routes routes)
        {
            if (routes == null) throw new ArgumentNullException("Entity");
            entities.Add(routes);
            context.SaveChanges();
            return routes.Id;
        }
        public IEnumerable<Routes> GetVehicles()
        {
            return context.Set<Routes>().AsEnumerable();
        }
       
    }
}
