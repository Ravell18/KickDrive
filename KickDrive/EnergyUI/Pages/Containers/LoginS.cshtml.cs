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
    public class LoginSModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        public IRepositoryValidar repositorycuentas;

        public int i;

        public LoginSModel(IRepositoryValidar repositorycuentas)
        {
            this.repositorycuentas = repositorycuentas;

        }
        public IActionResult OnPost()
        {
            i = repositorycuentas.Validar(user);

            if (i >= 1)
            {
                return Redirect("/Containers/ContRuta");

            }
            return Redirect("/Containers/LoginS");
        }

    }
}