using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Models;
using EnergyController.Services;
using EnergyController.Services.Controladores;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EnergyUI.Pages.Containers
{
    public class EditVehiclesModel : PageModel
    {
        [BindProperty]
        public Vehicles Vehicles { get; set; }
        public SelectList vehiculos {get; private set;}
        public readonly IRepository<Vehicles> VRepository;
  
    public EditVehiclesModel(IRepository<Vehicles> VRepository)
    {
        this.VRepository = VRepository;
    }
 
    public void OnGet(int Id)
    {
            Vehicles = VRepository.Get(Id);
    }
    public IActionResult OnPost(Vehicles vehicles)
    {
        VRepository.Update(vehicles);
        return Page();
    }
    
    }
}