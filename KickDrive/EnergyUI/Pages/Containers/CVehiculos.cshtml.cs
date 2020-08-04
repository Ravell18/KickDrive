using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyController.Models;
using EnergyController.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnergyUI.Pages.Containers
{
    public class CVehiculosModel : PageModel
    {
        private readonly IRepository<Vehicles> repository;
        public IEnumerable<Vehicles> Vehicles { get; private set; }
        public CVehiculosModel(IRepository<Vehicles>repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet()
        {
            try
            {
                Vehicles = repository.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFount");
            }
        }
    }
}