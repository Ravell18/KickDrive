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
    public class EditDriverModel : PageModel
    {
        [BindProperty]
        public Driver Driver { get;  set; }
        public SelectList Conductores { get; private set; }
        public  readonly IRepository<Driver> DRepository;
        public EditDriverModel(IRepository<Driver> DRepository)
        {
            this.DRepository = DRepository;
        }
        public void OnGet(int Id)
        {
            Driver = DRepository.Get(Id);
        }
        public IActionResult OnPost(Driver driver)
        {
           DRepository.Update(driver);
            return Page();
        }

    }
}
