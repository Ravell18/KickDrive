using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Models;
using EnergyController.Services;

namespace EnergyUI.Pages.Containers
{
    public class CDriverModel : PageModel
    {
        private readonly IRepository<Driver> repository;
        public IEnumerable<Driver> Drivers { get; private set; }
        public CDriverModel(IRepository<Driver> repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet()
        {
            try
            {
                Drivers = repository.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFount");
            }
        }
    }
}