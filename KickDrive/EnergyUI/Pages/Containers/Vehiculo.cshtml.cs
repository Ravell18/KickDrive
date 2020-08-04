using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Services;
using EnergyController.Models;

namespace EnergyUI.Pages.Containers
{
    public class Index4Model : PageModel
    {
        [BindProperty]
        public Vehicles Vehicles { get; set; }
        public IRepositoryVehicles repositoryVehicles;
      
        public Index4Model(IRepositoryVehicles repositoryVehicles)
        {
            this.repositoryVehicles = repositoryVehicles;
        }

        public void OnPost()
        {
            repositoryVehicles.InsertS(Vehicles);
        }
    }
}